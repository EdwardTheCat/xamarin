using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using AppTestingJSON.Model;
using AppTestingJSON.Service;
using System.Diagnostics;
using System.ComponentModel;


namespace AppTestingJSON
{
   
    public partial class MainPage : ContentPage
    {
        public StackLayout layout = new StackLayout()
        {
            Spacing = 0,
            Orientation = StackOrientation.Vertical,

        };
        public MainPage()
        {
            InitializeComponent();
            setView();
        }     
        async void OnButtonClicked(object sender, EventArgs args)
        {
                RestService rs = new RestService();
                Book book = new Book();
                try
                {
                    book = await rs.RefreshDataAsync();
                }
                catch (Exception e) { Console.WriteLine("Exception..."); } 

                addUserToWiew(book);
                Content = layout;
        }

        public void addUserToWiew(Book book)
        {

            Label labelId = new Label
            {
                Text = "ID : " + book._Id, 
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Label labelTitle = new Label
            {   Text = book.Title,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            layout.Children.Add(labelTitle);

            Label labelAuthor = new Label
            {
                Text = "Auteur : " + book.Author.name +" "+ book.Author._id+" "+ book.Author.__v,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            layout.Children.Add(labelAuthor);

            Label labelGenre = new Label
            {
                Text = "Genre : " + book.LiteraryGenre,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            layout.Children.Add(labelGenre);

            var image = new Image { Source = book.externalImage };
            layout.Children.Add(image);

            Label labelIsbn = new Label
            {
                Text = "ISBN : " + book.Isbn,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            layout.Children.Add(labelIsbn);

            Label labelContent = new Label
            {
                Text = book.Content.brief,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Margin = new Thickness(20, 0)
            };
            layout.Children.Add(labelContent);

            //labelid.bindingcontext = book;
            //// bind the new data source to the text property.
            //labelid.setbinding(label.textproperty, "_id");
            //layout.children.add(labelid);
        }
        public void setView()
        {
            Button button = new Button
            {
                Text = "GET",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            layout.Children.Add(button);
            button.Clicked += OnButtonClicked;
            Content = layout;
        }




    }


}
