using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using SQLite;
using System.IO;

namespace theStudioApp
{
    public class fragSignUp : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            //notifies when fragments are run
            base.OnCreate(savedInstanceState);
            Toast.MakeText(Context.ApplicationContext, "fragSignUp oncreate has been run", ToastLength.Short).Show();

        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle svaedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.layoutSignUp, container, false);

            return base.OnCreateView(inflater, container, svaedInstanceState);
        }
    }
}