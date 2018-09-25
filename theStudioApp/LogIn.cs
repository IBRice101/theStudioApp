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
    [Activity(Label = "theStudioApp", MainLauncher = true)]
    public class LogIn : Activity
    {
        string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layoutLogIn);

            FindViewById<Button>(Resource.Id.btnSubmit).Click += LogInRegister_clicked;
            FindViewById<Button>(Resource.Id.btnRegister).Click += (s, e) =>
            {
                StartActivity(new Intent(this, typeof(Register)));
            };
        }

        private void LogInRegister_clicked(object sender, EventArgs e)
        {
            if (validateUser(FindViewById<EditText>(Resource.Id.userNameEmailAddress).Text, FindViewById<EditText>(Resource.Id.txtPassword).Text))
            {
                Intent intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            }
            else
            {
                Toast.MakeText(Application.Context.ApplicationContext, "Invalid username or password", ToastLength.Short).Show();
            }
        }
        private bool validateUser(string username, string password)
        {
            var db = new SQLiteConnection(Path.Combine(folder, "userDatabase.db"));
            try
            {
                if (db.Query<SignUpTable>("SELECT * FROM SignUpTable Where username =? AND password =?", username, password).Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}