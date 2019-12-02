# theStudioApp
The app I made for my Scripting and Programming course's Unit 4 Assignment 3

The app is written in Xamarin.android and makes use of the XML language for frontend and the C# programing language for logic with using SQLite; for backend functionality, a developer must rigidly stick to the material design methodology (https://material.io/design/) when building this app in order to integrate it into the android OS seamlessly.
 
1.	Assets
At present this folder is not in use, this is primarily due to the presence of the “Drawable” folder’s existence. Within the AboutAssets.txt file, the only file in that folder, is this message:
Any raw assets you want to be deployed with your application can be placed in
this directory (and child directories) and given a Build Action of "AndroidAsset".

These files will be deployed with you package and will be accessible using Android's
AssetManager, like this:

public class ReadAsset : Activity
{
	protected override void OnCreate (Bundle savedinstanceState)
	{
		base.OnCreate (savedinstanceState);
		InputStream input = Assets.Open ("my_asset.txt");
	}
}

Additionally, some Android functions will automatically load asset files:

Typeface tf = Typeface.CreateFromAsset (Context.Assets, "fonts/samplefont.ttf");

It is not beyond the realm of feasibility that a future developer may decide to migrate any assets from their presently existing folders into the Assets folder however this may not achieve anything other than being aesthetically pleasing and present a further ease of understanding to any future developer.	
2.	Frags
The Frags, or Fragments folder, houses the code that is required to deploy the fragments for each page of the app, the following code example is from the fragAboutUs.cs file and is essentially identical from the rest apart from the highlighted sections, which change depending on the page each frag is calling:

namespace theStudioApp
{
    public class fragAboutUs : Fragment
    {
        public override void OnCreate(Bundle savedinstanceState)
        {
            //notifies when fragments are run
            base.OnCreate(savedinstanceState);
            Toast.MakeText(Context.ApplicationContext, "fragAboutUs oncreate has been run", ToastLength.Short).Show();
        }
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedinstanceState)
        {
            //gets the layout file and makes it a view, inflates it to the size of the screen
            return inflater.Inflate(Resource.Layout.layoutAboutUs, container, false);
            //TODO: remove unreachable code below
            //return base.OnCreateView(inflater, container, savedinstanceState);
        }
    }
}

3.	Resources
This folder has the majority of content within the app nested within folders herein and as such is arguably the most important folder, making changes (specifically removing items) here is not advised whatsoever.
a.	Drawable
This folder contains the icons and images used for display within the app. For the most part the images herein are .jpg files, however where necessary (for the proprietary Studio logo) .png files are used.
However for icons, specifically the material icons used for navigation in this instance, must be encoded as an .xml file in the svg, scalable vector graphic format. This is to ensure graphics do not lose quality if or when they need to be scaled. What follows is the full svg formatted .xml file describing the home icon, with comments
<vector xmlns:android="http://schemas.android.com/apk/res/android"
    android:width="24dp"
    android:height="24dp"
    android:viewportHeight="24.0"
    android:viewportWidth="24.0">
    <!-- 
    in pathData 
    M/m moves cursor to position, always followed by x,y coords
    Z/z draws a line to current position of cursor to start position
    L/l draws line from current position to position specified by x,y
    H/h draws horizontal line from current to position specified by x
    V/v draws vertical line from current to position specified by y
    Uppercase = absolute, lowercase = relative
    -->
    <path
        android:fillColor="#FF000000"
        android:pathData="M10,20v-6h4v6h5v-8h3L12,3 2,12h3v8z" />

    <TextView 
          />
</vector>
b.	Layout
Written in XML to serve as the front end of the app, contains code for buttons, text boxes, images, and text. What follows is the code for the smallest page, the login page

<?xml version="1.0" encoding="utf-8"?>
<!-- the whole page is nested in a scrollview so the page can be scrolled if the 
amount of content on the page doesn't fit the screen its displayed on -->
<ScrollView xmlns:android="http://schemas.android.com/apk/res/android"
    android:layout_width="match_parent"
    android:layout_height="match_parent">
	<!-- linear layout describes a visual layout that is linear, i.e. one 
	after another -->
    <LinearLayout
        android:orientation="vertical"
        android:layout_width="match_parent"
        android:layout_height="match_parent">
		<!-- the studio logo as called from the drawable file -->
        <ImageView
            android:layout_width="wrap_content"
            android:layout_height="wrap_content"
            android:src="@drawable/studioLogo" />
		<!-- text saying 'log in' as called from the strings file -->
        <TextView
            android:id="@+id/title_logIn"
            android:layout_height="wrap_content"
            android:layout_width="wrap_content"
            android:text="@string/title_logIn"
            android:textSize="32sp" />
        <TextView
            android:id="@+id/userName"
            android:layout_height="wrap_content"
            android:layout_width="wrap_content"
            android:text="Username / Email Address" />
		<!-- an input box for the username and/or email address -->
        <EditText
            android:layout_width="match_parent"
            android:layout_height="wrap_content"
            android:id="@+id/userNameEmailAddress" />
        <TextView
            android:id="@+id/password"
            android:layout_height="wrap_content"
            android:layout_width="wrap_content"
            android:text="@string/password" />
        <EditText
            android:inputType="textPassword"
            android:layout_width="match_parent"
            android:layout_height="wrap_content"
            android:id="@+id/txtPassword" />
        <Button
            android:text="Submit"
            android:layout_width="match_parent"
            android:layout_height="wrap_content"
            android:id="@+id/btnSubmit"
            android:background="@color/colorAccent" />
        <Button
            android:text="Register"
            android:layout_width="match_parent"
            android:layout_height="wrap_content"
            android:id="@+id/btnRegister"
            android:background="@color/colorPrimary"
            android:textColor="@color/colorAccent" />
    </LinearLayout>
</ScrollView> 

c.	Menu
This folder houses the navigation functionality, i.e. the menu, in the application, all of the content pages pull from this menu and frags are run based off of what are essentially onclick event handlers from this menu system.
What follows is the code for the menu, it contains three items, home, about us, and contact us, and are labelled as such
<?xml version="1.0" encoding="utf-8"?>
<menu xmlns:android="http://schemas.android.com/apk/res/android">

    <item
        android:id="@+id/navigation_home"
        android:icon="@drawable/ic_home_black_24dp"
        android:title="@string/title_home" />

    <item
        android:id="@+id/navigation_aboutUs"
        android:icon="@drawable/ic_aboutUs_black_24dp"
        android:title="@string/title_aboutUs" />

    <item
      android:id="@+id/navigation_contactUs"
      android:icon="@drawable/ic_contactUs_black_24dp"
      android:title="@string/title_contactUs" />

</menu>
d.	Mipmap
The Mipmap series of six folders serve to house increasingly sized versions of the app’s icon, as seen below:
 
Five of the six folders (mipmap-mdpi – xxxhdpi) house .png files of the icon itself (as well as the rounded variant), with the anydpi folder serving to house references to colour values the icon holds, this is as seen below:
<?xml version="1.0" encoding="utf-8"?>
<adaptive-icon xmlns:android="http://schemas.android.com/apk/res/android">
    <background android:drawable="@color/ic_launcher_background"/>
    <foreground android:drawable="@mipmap/ic_launcher_foreground"/>
</adaptive-icon>
e.	Values
The values folder contains, as the name suggests, all of the values required for use in the app. As previously explained, the way this implementation of Xamarin works is instead of having content such as colour values, text, and other stylings written inline or in a single, separate file that explicitly corresponds to a specific section of the app (Like with HTML/CSS), all values are declared in a separate folder with different files representing different uses, and are then referenced by a declared name elsewhere in the program.
As a simple example, say a developer wants to display the word ‘Home’ as a title in one of the screens in their app, instead of:
<TextView
            android:id="@+id/title_home"
            android:layout_height="wrap_content"
            android:layout_width="fill_parent"
            android:text="Home"
            android:textSize="32sp" />
They would instead write:
<TextView
            android:id="@+id/title_home"
            android:layout_height="wrap_content"
            android:layout_width="fill_parent"
            android:text="@string/title_home"
            android:textSize="32sp" />
And in …\values\strings.xml we would see:
<string name="title_home">Home</string>
4.	Miscellaneous and Other
The final set of files occupy space outside of folders within the root of the solution, these files, from a development standpoint, are ideally not to be altered as they form the basis for several crucial basic tasks of functionality, such as frag switching and logging in, that should be accessed as quickly and as easily as possible by any other section of the application.  
