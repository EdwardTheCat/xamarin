using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AppLoginHibooks.Model
{
    public class User : INotifyPropertyChanged
    {
        private string _id = "";
        public string _Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged("_Id");
            }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged("Email");
            }
        }
        private string username;
        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                OnPropertyChanged("Username");
            }
        }

        private string __v;
        public string __V
        {
            get { return __v; }
            set
            {
                __v = value;
                OnPropertyChanged("__V");
            }
        }

        private bool isAdmin;
        public bool IsAdmin
        {
            get { return isAdmin; }
            set
            {
                isAdmin = value;
                OnPropertyChanged("IsAdmin");
            }
        }
        private int[] friends;
        public int[] Friends
        {
            get { return friends; }
            set
            {
                friends = value;
                OnPropertyChanged("Friends");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string info)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(info));
            }
        }
    }
}
