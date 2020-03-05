using Microsoft.Data.SqlClient;
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

namespace AsteroidShooterGUI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //WELCOME WINDOW INITIALIZATION
        AsteroidShooter asteroidShooterWindow = new AsteroidShooter();

        //APPLICATION DRAG MOVE METHOD
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        //REGISTRATION REDIRECT METHOD
        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            RegistrationForm registrationFormObject = new RegistrationForm();
            registrationFormObject.Show();
            this.Close();
        }

        //LOGIN BUTTON METHOD
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (usernameText.Text.Length == 0)
            {
                errormessage.Text = "Please enter a valid username";
                usernameText.Focus();
            }
            else
            {
                //User login input fields
                string username = usernameText.Text;
                string password = passwordText.Password;

                errormessage.Text = "";

                //Set SQL Credentials
                SqlConnection connection = new SqlConnection(
                    "Data Source = localhost;" +
                    "Initial Catalog = UserDatabase;" +
                    "User ID = SA;" +
                    "Password= Passw0rd2018;");

                //Open New SQL Connection
                connection.Open();

                //SQL DML Query
                SqlCommand command = new SqlCommand(
                    "SELECT * " +
                    "FROM Users WHERE username ='" + username + "'  and password ='" + password + "'", connection);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    //Send User Credentials From One Form To Another
                    string welcomeName = dataSet.Tables[0].Rows[0]["firstName"].ToString() + " " + dataSet.Tables[0].Rows[0]["lastName"].ToString();
                    asteroidShooterWindow.TextBlockName.Text = welcomeName;
                    asteroidShooterWindow.Show();
                    Close();
                }
                else
                {
                    errormessage.Text = "Incorrect username or password";
                }
                connection.Close();
            }
        }
    }
}