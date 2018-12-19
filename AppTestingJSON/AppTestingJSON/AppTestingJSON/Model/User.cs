using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AppTestingJSON.Model
{
    public class User : INotifyPropertyChanged
    {
        private string userId;
        public string UserId {
            get { return userId; }
            set
            {
                userId = value;
                OnPropertyChanged("UserId");
            }
        }

        private string id;
        public string Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }

        private string title;
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged("Title");
            }
        }

        private string completed;
        public string Completed
        {
            get { return completed; }
            set
            {
                id = value;
                OnPropertyChanged("Completed");
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
