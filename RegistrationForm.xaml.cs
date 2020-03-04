using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Navigation;
using AsteroidShooterGUI.Database_Models;
using Microsoft.Data.SqlClient;

namespace AsteroidShooterGUI
{
    public partial class RegistrationForm : Window
    {

        private User newUser;

        //Initialize Registration Form
        public RegistrationForm()
        {
            InitializeComponent();
        }

        //APPLICATION DRAG MOVE METHOD
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        //RESET TEXT BOX METHOD
        public void Reset()
        {
            firstNameText.Text = "";
            lastNameText.Text = "";
            usernameText.Text = "";
            passwordText.Password = "";
            passwordConfirmText.Password = "";
        }

        //BACK REDIRECT METHOD
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindowObject = new MainWindow();
            MainWindowObject.Show();
            this.Close();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            //User Textbox Input Fields
            string firstName = firstNameText.Text;
            string lastName = lastNameText.Text;
            string userName = usernameText.Text;
            string password = passwordText.Password;

            //Password Parameters
            if (passwordText.Password.Length == 0)
            {
                errormessage.Text = "Please enter a password";
                passwordText.Focus();
            }

            //Password Confirmation
            else if (passwordConfirmText.Password.Length == 0)
            {
                errormessage.Text = "Please confirm your password";
                passwordConfirmText.Focus();
            }
            else if (passwordText.Password != passwordConfirmText.Password)
            {
                errormessage.Text = "Password is not matching";
                passwordConfirmText.Focus();
            }
            //SQL Database Entry
            else
            {
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
                    "INSERT INTO Users " +
                    "(firstName, lastName, userName, password) " +
                    "VALUES('" + firstName + "','" + lastName + "','" + userName + "','" + password + "')", connection);

                command.ExecuteNonQuery();
                errormessage.Text = "You have registered successfully!";
                Reset();
            }
        }
    }
}

