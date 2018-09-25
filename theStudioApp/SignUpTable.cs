using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;

namespace theStudioApp
{
    public class SignUpTable
    {
        [PrimaryKey, AutoIncrement, Column("ID")]
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string username { get; set; }
        public string emailAddress { get; set; }
        public string phoneNumber { get; set; }
        public string password { get; set; }
    }
}