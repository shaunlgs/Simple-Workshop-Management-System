using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Interaction logic for AddCustomerWindow.xaml
    /// </summary>
    public partial class AddCustomerWindow : Window
    {
        public AddCustomerWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void AddCustomerBtnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=localhost;username=root;password=root";
                string Query = "insert into WMS.customer(FirstName, LastName, Phone) values('" + this.FirstNameTextbox.Text + "','" + this.LastNameTextbox.Text + "','" + this.PhoneTextbox.Text + "');";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();

                long id = MyCommand2.LastInsertedId;
                Query = "insert into WMS.address(Street, City, Postcode, State, CustomerID) values('" + this.StreetTextbox.Text + "','" + this.CityTextbox.Text + "','" + this.PostcodeTextbox.Text + "','"  + this.StateTextbox.Text + "', " + id.ToString() + ");";
                MyConn2 = new MySqlConnection(MyConnection2);
                MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();

                MessageBox.Show("Customer Added");

                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }
    }
}
