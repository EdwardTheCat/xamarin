﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppLoginHibooks.View;
using AppLoginHibooks.Data;
using AppLoginHibooks.Model;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AppLoginHibooks
{
    public partial class App : Application
    {
        public static User user;
        public App()
        {
            InitializeComponent();
            user = new User();
            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
