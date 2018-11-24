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
    /// Interaction logic for ViewInvoicesWindow.xaml
    /// </summary>
    public partial class ViewInvoicesWindow : Window
    {
        public ViewInvoicesWindow()
        {
            InitializeComponent();
            try
            {
                string MyConnection2 = "datasource=localhost;username=root;password=root";
                string Query = "select InvoiceCode, Date, Method, GROUP_CONCAT(WorkOrderCode2) from WMS.invoice INNER JOIN wms.invoice_workorder ON wms.invoice.InvoiceCode = wms.invoice_workorder.InvoiceCode2";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                DataTable dTable = new DataTable();
                MyAdapter.SelectCommand = MyCommand2;
                MyAdapter.Fill(dTable);
                InvoicesDataGrid.ItemsSource = dTable.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
