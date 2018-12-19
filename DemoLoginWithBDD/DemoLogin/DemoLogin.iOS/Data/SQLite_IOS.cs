using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using DemoLogin.Data;
using DemoLogin.iOS.Data;
using Foundation;
using SQLite;
using UIKit;
using Xamarin.Forms;

[assembly : Dependency(typeof(SQLite_IOS))]
namespace DemoLogin.iOS.Data
{
    class SQLite_IOS : ISQLite
    {
        public SQLite_IOS() { }
        public SQLiteConnection GetConnection()
        {
            var sqliteFileName = "TestDB.db3";
            var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var libraryPath = Path.Combine(documentsPath, "..", "library");
            var path = Path.Combine(libraryPath, sqliteFileName);
            SQLiteConnection conn = new SQLiteConnection(path);

            return conn;
        }
    }
}