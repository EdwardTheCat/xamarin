﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DemoLogin.Data;
using DemoLogin.Droid.Data;
using SQLite;
using Xamarin.Forms;

[assembly : Dependency(typeof(SQLite_Android))]
namespace DemoLogin.Droid.Data
{
    class SQLite_Android : ISQLite
    {
        public SQLite_Android() {}

        public SQLiteConnection GetConnection()
        {
            var sqliteFileName = "TestDB.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFileName);
            var conn = new SQLiteConnection(path);

            return conn;
        }
    }
}