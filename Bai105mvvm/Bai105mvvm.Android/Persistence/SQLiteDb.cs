using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Bai105mvvm.Droid.Persistence;
using Bai105mvvm.Persistence;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
[assembly:Xamarin.Forms.Dependency(typeof(SQLiteDb))]
namespace Bai105mvvm.Droid.Persistence
{
    class SQLiteDb : ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentPath, "MySqlite.db3");
            return new SQLiteAsyncConnection(path);
        }
    }
}