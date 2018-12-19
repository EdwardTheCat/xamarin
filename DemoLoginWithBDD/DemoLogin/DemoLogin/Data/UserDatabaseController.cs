using DemoLogin.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DemoLogin.Data
{
    public class UserDatabaseController
    {
        public Object locker = new object();
        SQLiteConnection database;

        public UserDatabaseController()
        {
            database = DependencyService.Get<ISQLite>.GetConnection();
            database.CreateTable<User>();
               
    }
}
