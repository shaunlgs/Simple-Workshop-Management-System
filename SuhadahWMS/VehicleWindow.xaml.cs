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
    /// Interaction logic for VehicleWindow.xaml
    /// </summary>
    public partial class VehicleWindow : Window
    {
        public VehicleWindow()
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
        }

        private void AddVehicleBtnClick(object sender, RoutedEventArgs e)
        {
            // Add vehicle into database
            try
            {
                string MyConnection2 = "datasource=localhost;username=root;password=root";
                string Query = "insert into WMS.vehicle(RegistrationNo, CustomerID2, ChassisNo, Make, Model, Year, Engine, Transmission, FuelType, Mileage) values('"
                    + this.RegistrationNoTextbox.Text + "','" + this.CustomerIDComboBox.Text.Split(' ')[0] + "','" + this.ChassisNoTextbox.Text + "','"
                    + this.MakeTextbox.Text + "','" + this.ModelTextbox.Text + "','" + this.YearTextbox.Text + "','"
                    + this.EngineTextbox.Text + "','" + this.TransmissionTextbox.Text + "','" + this.FuelTypeTextbox.Text
                    +"','" + this.MileageTextbox.Text + "');";
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
        }
    }
}
