using Android.App;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using SQLite;

namespace theStudioApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class MainActivity : AppCompatActivity, BottomNavigationView.IOnNavigationItemSelectedListener
    {
        private TextView _textMessage;

        public bool OnNavigationItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                //if a user navigates to screen x create fragX and switch to it
                case Resource.Id.navigation_home:
                    SwitchToFrag(new fragHome());
                    return true;
                case Resource.Id.navigation_aboutUs:
                    SwitchToFrag(new fragAboutUs());
                    return true;
                case Resource.Id.navigation_contactUs:
                    SwitchToFrag(new fragContactUs());
                    return true;
            }
            return false;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            SwitchToFrag(new fragHome());

            BottomNavigationView navigation = FindViewById<BottomNavigationView>(Resource.Id.navigation);
            navigation.SetOnNavigationItemSelectedListener(this);
        }

        //class that allows switching between fragments
        protected void SwitchToFrag(Fragment frag)
        {
            FragmentTransaction transaction = FragmentManager.BeginTransaction();
            transaction.Replace(Resource.Id.fragMainContainer, frag).SetTransition(FragmentTransit.FragmentFade).Commit();
        }

        public void insertInto (View view)
        {
            //SQLiteCommand cmd = new 
        }
    }
    
}

