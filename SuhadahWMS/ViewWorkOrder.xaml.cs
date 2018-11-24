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
    /// Interaction logic for ViewWorkOrder.xaml
    /// </summary>
    public partial class ViewWorkOrder : Window
    {
        public ViewWorkOrder()
        {
            InitializeComponent();
            try
            {
                string MyConnection2 = "datasource=localhost;username=root;password=root";
                string Query = "select wms.work_order.WorkOrderCode, wms.work_order.Description, wms.work_order.AdvisoryNote, TotalCost, CustomerID3, WorkOrderTime, GROUP_CONCAT(wms.inventory.InventoryCode), GROUP_CONCAT(NumberOfUnits), GROUP_CONCAT(wms.inventory.Description), GROUP_CONCAT(SupplierCode), GROUP_CONCAT(CostPerUnit) from WMS.work_order INNER JOIN WMS.work_order_inventory ON WMS.work_order.WorkOrderCode = WMS.work_order_inventory.WorkOrderCode INNER JOIN WMS.inventory ON WMS.work_order_inventory.InventoryCode = WMS.inventory.InventoryCode GROUP BY WMS.work_order.WorkOrderCode";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                DataTable dTable = new DataTable();
                MyAdapter.SelectCommand = MyCommand2;
                MyAdapter.Fill(dTable);
                WorkOrderDataGrid.ItemsSource = dTable.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
