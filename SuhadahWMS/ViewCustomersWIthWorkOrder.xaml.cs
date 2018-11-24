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
    /// Interaction logic for ViewCustomersWIthWorkOrder.xaml
    /// </summary>
    public partial class ViewCustomersWIthWorkOrder : Window
    {
        public ViewCustomersWIthWorkOrder()
        {
            InitializeComponent();

            try
            {
                string MyConnection2 = "datasource=localhost;username=root;password=root";
                string Query = "select WMS.customer.CustomerID, FirstName, LastName, Phone, Street, City, Postcode, State, GROUP_CONCAT(WorkOrderCode) from WMS.customer INNER JOIN WMS.address ON WMS.customer.CustomerID = WMS.address.CustomerID INNER JOIN WMS.work_order ON WMS.customer.CustomerID = WMS.work_order.CustomerID3";

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
    }
}
