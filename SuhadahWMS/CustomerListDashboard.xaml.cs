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
    /// Interaction logic for CustomerListDashboard.xaml
    /// </summary>
    public partial class CustomerListDashboard : Window
    {
        public CustomerListDashboard()
        {
            InitializeComponent();

            try
            {
                string MyConnection2 = "datasource=localhost;username=root;password=root";
                string Query = "select WMS.customer.CustomerID, FirstName, LastName, Phone, Street, City, Postcode, State from WMS.customer INNER JOIN WMS.address ON WMS.customer.CustomerID = WMS.address.CustomerID";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                DataTable dTable = new DataTable();
                MyAdapter.SelectCommand = MyCommand2;
                MyAdapter.Fill(dTable);
                CustomerDataGrid.ItemsSource = dTable.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataGridRow row = sender as DataGridRow;
            // Some operations with this row
        }
    }
}
