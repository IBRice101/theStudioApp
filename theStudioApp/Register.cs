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
using System.IO;

namespace theStudioApp
{
    [Activity(Label = "Register")]
    public class Register : Activity
    {
        string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layoutSignUp);

            FindViewById<Button>(Resource.Id.btnSubmit).Click += BtnSubmit_clicked;
        }

        private void BtnSubmit_clicked(object sender, EventArgs e)
        {
            var db = new SQLiteConnection(Path.Combine(folder, "userDatabase.db"));
            db.CreateTable<SignUpTable>();
            SignUpTable user = new SignUpTable
            {

                firstName = FindViewById<TextView>(Resource.Id.txtFirstName).Text,
                lastName = FindViewById<TextView>(Resource.Id.txtLastName).Text,
                username = FindViewById<TextView>(Resource.Id.txtUserName).Text,
                emailAddress = FindViewById<TextView>(Resource.Id.txtEmailAddress).Text,
                phoneNumber = FindViewById<EditText>(Resource.Id.txtPhoneNumber).Text,
                password = FindViewById<TextView>(Resource.Id.txtPassword).Text
            };

            db.Insert(user);
        }
    }
}