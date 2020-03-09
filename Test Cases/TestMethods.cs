using System;
using System.Collections.Generic;
using System.Text;

namespace AsteroidShooterGUI.Test_Cases
{
    public class TestMethods
    {
        //FIELDS
        private string _username;
        private string _password;
        private string _passwordConfirmation;

        //USERNAME PROPERTY
        public string Username
        {
            get { return _username; }
            set
            {
                if (Username.Length != 0)
                {
                    _username = value;
                }
            }
        }

        //PASSWORD PROPERTY
        public string Password
        {
            get { return _password; }
            set
            {
                if (Password.Length != 0)
                {
                    _password = value;
                }
            }
        }

        //PASSWORD CONFIRMATION
        public string PasswordConfirmation
        {
            get { return _passwordConfirmation; }
            set
            {
                if (Password.Length != 0)
                {
                    _passwordConfirmation = value;
                }
            }
        }

        //USER REGISTRATION METHOD
        public string Registration()
        {
            if (_password != null && _username != null)
            {
                return "You have registered successfully!";
            }
            else
            {
                return "Please input in your name or password";
            }
        }

        //USER REGISTRATION METHOD
        public string Confirmation()
        {
            if (_password == _passwordConfirmation)
            {
                return "You have registered successfully!";
            }
            else
            {
                return "Password is not matching";
            }
        }
    }
}
