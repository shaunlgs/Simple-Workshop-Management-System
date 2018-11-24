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
    /// Interaction logic for AddWorkOrderWindow.xaml
    /// </summary>
    public partial class AddWorkOrderWindow : Window
    {
        public AddWorkOrderWindow()
        {
            InitializeComponent();

            // get all customer IDs to show in combobox
            try
            {
                string MyConnection2 = "datasource=localhost;username=root;password=root";
                string Query = "select CustomerID, CONCAT(CustomerID, ' ', FirstName) as data from WMS.customer;";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                DataTable dTable = new DataTable();
                MyAdapter.SelectCommand = MyCommand2;
                MyAdapter.Fill(dTable);
                CustomerIDComboBox.ItemsSource = dTable.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // get all Inventory Codes to show in List Box
            try
            {
                string MyConnection2 = "datasource=localhost;username=root;password=root";
                string Query = "select InventoryCode, CostPerUnit from WMS.inventory;";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                DataTable dTable = new DataTable();
                MyAdapter.SelectCommand = MyCommand2;
                MyAdapter.Fill(dTable);
                InventoryCodesListBox.ItemsSource = dTable.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddSupplierBtnClick(object sender, RoutedEventArgs e)
        {

            // calculate total cost - assume each inventory quantity is 1 for now
            Double totalCost = 0.00;
            foreach (DataRowView item in InventoryCodesListBox.SelectedItems)
            {
                totalCost += Convert.ToDouble(item.Row["CostPerUnit"]);
            }

                // Store data in work_order table
                try
            {
                string MyConnection2 = "datasource=localhost;username=root;password=root";
                string Query = "insert into WMS.work_order(WorkOrderCode, Description, AdvisoryNote, TotalCost, CustomerID3, WorkOrderTime) values('"
                    + this.WorkOrderCodeTextbox.Text + "','" + this.DescriptionTextbox.Text + "','" + this.AdvisoryNoteTextbox.Text + "',"
                    + totalCost + ",'" + this.CustomerIDComboBox.Text.Split(' ')[0] + "','" + DateTime.Parse(this.WorkOrderTime.DisplayDate.ToShortDateString()).ToString("yyyy-MM-dd") + "');";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();

                MessageBox.Show("Work Order Added");

                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Store data in work_order_inventory table (assume each inventory quantity is 1 for now)

            foreach (DataRowView item in InventoryCodesListBox.SelectedItems)
            {
                String InventoryCode = item.Row["InventoryCode"].ToString();
                totalCost += Convert.ToDouble(item.Row["CostPerUnit"]);
                try
                {
                    string MyConnection2 = "datasource=localhost;username=root;password=root";
                    string Query = "insert into WMS.work_order_inventory(WorkOrderCode, InventoryCode, NumberOfUnits) values('"
                        + this.WorkOrderCodeTextbox.Text + "','" + InventoryCode + "','" + "1" + "');";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();

                    MessageBox.Show("Work Order Inventory Added");

                    MyConn2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            //// Store data in customer_work_order table (each customer may have many work orders)
            //try
            //{
            //    string MyConnection2 = "datasource=localhost;username=root;password=root";
            //    string Query = "insert into WMS.customer_work_order(CustomerID4, WorkOrderCode3) values('"
            //        + this.CustomerIDComboBox.Text.Split(' ')[0] + "','" + this.WorkOrderCodeTextbox.Text + "');";
            //    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            //    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            //    MySqlDataReader MyReader2;
            //    MyConn2.Open();
            //    MyReader2 = MyCommand2.ExecuteReader();

            //    MessageBox.Show("Customer Work Order Added");

            //    MyConn2.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }

        private void RegistrationNoTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TotalCostTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CustomerIDComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
