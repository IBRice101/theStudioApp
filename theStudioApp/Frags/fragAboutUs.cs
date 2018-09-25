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

namespace theStudioApp
{
    public class fragAboutUs : Fragment
    {
        public override void OnCreate(Bundle svaedInstanceState)
        {
            //notifies when fragments are run
            base.OnCreate(svaedInstanceState);
            Toast.MakeText(Context.ApplicationContext, "fragAboutUs oncreate has been run", ToastLength.Short).Show();
            
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle svaedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.layoutAboutUs, container, false);

            return base.OnCreateView(inflater, container, svaedInstanceState);
        }
    }
}