﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchMod1Week5Assessment
{
    public class User
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        private string Password { get; set; }
        public bool IsLoggedIn { get; set; }

        public User(string name, string email)
        {
            Name = name;
            Email = email;
            IsLoggedIn = false;
        }

        public bool IsSetupComplete()
        {
            if (Name != null && Email != null && Password != null)
            {
               return true;
            }
            else
            {
                return false;
            }
        }

        public string CreatePassword(string email, string password) // changed return type to string to accomodate the confirmation variable
        {
            string confirmation;
            if (email == Email)
            {
                Password = password;
            } 

            if (Password != null)
            {
                confirmation = "Password Created";
            }
            else
            {
                confirmation = "Try again";
            }
            return confirmation; //refactored if/else statement to allow "confirmation" to be assigned to correct value and enabled method to return "confirmation"
        }

        public string LogIn(string password)
        {
            if (password == Password)
            {
                IsLoggedIn = true;
                return "Logged In";
            }
            return "Not Logged In";
        }

        public void LogOut()
        {
            IsLoggedIn = false;
        }
    }
}
