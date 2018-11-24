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
    /// Interaction logic for AddInventoryWindow.xaml
    /// </summary>
    public partial class AddInventoryWindow : Window
    {

        public AddInventoryWindow()
        {
            InitializeComponent();

            // get all supplier codes to show in combobox
            try
            {
                string MyConnection2 = "datasource=localhost;username=root;password=root";
                string Query = "select SupplierCode from WMS.supplier;";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                DataTable dTable = new DataTable();
                MyAdapter.SelectCommand = MyCommand2;
                MyAdapter.Fill(dTable);
                SupplierCodeComboBox.ItemsSource = dTable.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void AddInventoryBtnClick(object sender, RoutedEventArgs e)
        {
            // Add inventory into database
            try
            {
                string MyConnection2 = "datasource=localhost;username=root;password=root";
                string Query = "insert into WMS.inventory(InventoryCode, Description, SupplierCode, CostPerUnit) values('"
                    + this.InventoryCodeTextbox.Text + "','" + this.DescriptionTextbox.Text + "','" + this.SupplierCodeComboBox.Text + "','"
                    + this.CostPerUnitTextbox.Text + "');";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();

                MessageBox.Show("Inventory Added");

                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
