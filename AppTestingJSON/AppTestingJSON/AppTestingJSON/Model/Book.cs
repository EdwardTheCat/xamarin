using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AppTestingJSON.Model
{
    public class Book : INotifyPropertyChanged
    {
        private string _id;
        public string _Id
        {
           get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged("_Id");
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

        private Author author;
        public Author Author
        {
            get { return author; }
            set
            {
                author = value;
                OnPropertyChanged("Author");
            }
        }

        private String literaryGenre;
        public String LiteraryGenre
        {
            get { return literaryGenre; }
            set
            {
                literaryGenre = value;
                OnPropertyChanged("LiteraryGenre");
            }
        }
        public String isbn;

        public String Isbn
        {
            get { return isbn; }
            set
            {
                isbn = value;
                OnPropertyChanged("Isbn");
            }
        }

        public String externalImage;
        public String ExternalImage
        {
            get { return externalImage; }
            set
            {
                externalImage = value;
                OnPropertyChanged("ExternalImage");
            }
        }

        private String __v;
        public String __V
        {
            get { return __V; }
            set
            {
                __v = value;
                OnPropertyChanged("V");
            }
        }

        private Content content;
        public Content Content
        {
            get { return content; }
            set
            {
                content = value;
                OnPropertyChanged("Content");
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
    public class Author
    {
        public string _id { get; set; }
        public string name { get; set; }
        public string __v { get; set; }
    }

    public class Content
    {
        public string brief { get; set; }

    }
}
