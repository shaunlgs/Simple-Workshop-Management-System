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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SuhadahWMS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddSupplierBtnClick(object sender, RoutedEventArgs e)
        {
            AddSupplierWindow AddSupplierWindow = new AddSupplierWindow();
            AddSupplierWindow.Show();
        }

        private void AddVehicleBtnClick(object sender, RoutedEventArgs e)
        {
            VehicleWindow AddVehicleWindow = new VehicleWindow();
            AddVehicleWindow.Show();
        }

        private void AddInventoryBtnClick(object sender, RoutedEventArgs e)
        {
            AddInventoryWindow AddInventoryWindow = new AddInventoryWindow();
            AddInventoryWindow.Show();
        }

        private void AddWorkOrderBtnClick(object sender, RoutedEventArgs e)
        {
            AddWorkOrderWindow AddWorkOrderWindow = new AddWorkOrderWindow();
            AddWorkOrderWindow.Show();
        }

        private void AddInvoiceBtnClick(object sender, RoutedEventArgs e)
        {
            AddInvoiceWindow AddInvoiceWindow = new AddInvoiceWindow();
            AddInvoiceWindow.Show();
        }

        private void AddCustomerBtnClick(object sender, RoutedEventArgs e)
        {
            AddCustomerWindow AddCustomerWindow = new AddCustomerWindow();
            AddCustomerWindow.Show();
        }

        private void ViewCustomerBtnClick(object sender, RoutedEventArgs e)
        {
            CustomerListDashboard CustomerListDashboard = new CustomerListDashboard();
            CustomerListDashboard.Show();
        }

        private void ViewWorkOrderBtnClick(object sender, RoutedEventArgs e)
        {
            ViewWorkOrder ViewWorkOrder = new ViewWorkOrder();
            ViewWorkOrder.Show();
        }

        private void ViewInvoicesBtnClick(object sender, RoutedEventArgs e)
        {
            ViewInvoicesWindow ViewInvoicesWindow = new ViewInvoicesWindow();
            ViewInvoicesWindow.Show();
        }

        private void ViewCustomersWithWorkOrderBtnClick(object sender, RoutedEventArgs e)
        {
            ViewCustomersWIthWorkOrder ViewCustomersWIthWorkOrder = new ViewCustomersWIthWorkOrder();
            ViewCustomersWIthWorkOrder.Show();
        }

        private void DeleteAllDataBtnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=localhost;username=root;password=root";
                string Query = "SELECT table_name FROM information_schema.tables WHERE table_schema ='wms';";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                DataTable dTable = new DataTable();
                MyAdapter.SelectCommand = MyCommand2;
                MyAdapter.Fill(dTable);
                foreach (DataColumn col in dTable.Columns)
                {
                    foreach (DataRow row in dTable.Rows)
                    {
                        Console.WriteLine(row[col].ToString());
                        MyConnection2 = "datasource=localhost;username=root;password=root";
                        Query = "SET FOREIGN_KEY_CHECKS = 0; DELETE FROM WMS." + row[col].ToString() + "; SET FOREIGN_KEY_CHECKS = 1;";

                        MyConn2 = new MySqlConnection(MyConnection2);
                        MyCommand2 = new MySqlCommand(Query, MyConn2);
                        MySqlDataReader MyReader2;
                        MyConn2.Open();
                        MyReader2 = MyCommand2.ExecuteReader();
                    }
                }

                MessageBox.Show("Data deleted");



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
