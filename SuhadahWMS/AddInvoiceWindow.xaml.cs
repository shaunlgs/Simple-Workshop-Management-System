using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SuhadahWMS
{
    /// <summary>
    /// Interaction logic for AddInvoiceWindow.xaml
    /// </summary>
    public partial class AddInvoiceWindow : Window
    {
        public class ComboData
        {
            public string Value { get; set; }
        }

        public AddInvoiceWindow()
        {
            InitializeComponent();

            // Initialize Method ComboBox
            List<ComboData> ListData = new List<ComboData>();
            ListData.Add(new ComboData { Value = "Cash" });
            ListData.Add(new ComboData { Value = "Card" });

            MethodListBox.ItemsSource = ListData;
            MethodListBox.DisplayMemberPath = "Value";




            // get all Work Order Codes to show in List Box
            try
            {
                string MyConnection2 = "datasource=localhost;username=root;password=root";
                string Query = "select WorkOrderCode from WMS.work_order;";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                DataTable dTable = new DataTable();
                MyAdapter.SelectCommand = MyCommand2;
                MyAdapter.Fill(dTable);
                WorkOrderCodesListBox.ItemsSource = dTable.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddInvoiceBtnClick(object sender, RoutedEventArgs e)
        {
            // Add invoice into database
            try
            {
                string MyConnection2 = "datasource=localhost;username=root;password=root";
                string Query = "insert into WMS.invoice(InvoiceCode, Date, Method) values('"
                    + this.InvoiceCodeTextbox.Text + "','" + DateTime.Parse(this.DateTextbox.DisplayDate.ToShortDateString()).ToString("yyyy-MM-dd") + "','" + this.MethodListBox.Text + "');";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();

                MessageBox.Show("Vehicle Added");

                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            // Add entries in invoice_workorder table
            foreach (DataRowView item in WorkOrderCodesListBox.SelectedItems)
            {
                String WorkOrderCode = item.Row["WorkOrderCode"].ToString();
                try
                {
                    string MyConnection2 = "datasource=localhost;username=root;password=root";
                    string Query = "insert into WMS.invoice_workorder(InvoiceCode2, WorkOrderCode2) values('"
                        + this.InvoiceCodeTextbox.Text + "','" + WorkOrderCode + "');";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();

                    MessageBox.Show("Invoice Work Order Added");

                    MyConn2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
