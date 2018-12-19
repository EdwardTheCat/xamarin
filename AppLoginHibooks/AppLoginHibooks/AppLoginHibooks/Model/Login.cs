using System;
using System.Collections.Generic;
using System.Text;

namespace AppLoginHibooks.Model
{
    public class Login
    { 
        public string Email { get; set; }
        public string Password { get; set; }

        public Login() { }
        public Login(string email, string password)
        {
            this.Email = email;
            this.Password = password;
        }
    }
}
