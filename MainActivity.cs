using Android.App;
using Android.Widget;
using Android.OS;

namespace Rbay
{
    [Activity(Label = "Rbay", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button loginButton = FindViewById<Button>(Resource.Id.LoginButton);
            Button registerButton = FindViewById<Button>(Resource.Id.RegisterButton);


            loginButton.Click += delegate {
                //button.Text = string.Format ("{0} clicks!", sent);
                Toast.MakeText(this,"You have been successfully logged in",ToastLength.Long).Show();
		//SetContentView(Resource.Layout.LayoutLogin);
		StartActivity(typeof(ActivityLogin));
            };
            registerButton.Click += delegate {
                //button.Text = string.Format ("{0} clicks!", sent);
                Toast.MakeText(this,"You have been successfully registered",ToastLength.Long).Show();
            };
        }
	}
}

