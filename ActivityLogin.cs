
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

namespace Rbay
{
    [Activity(Label = "ActivityLogin")]
    public class ActivityLogin : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            	// Create your application here
           	SetContentView(Resource.Layout.LayoutLogin);
           	EditText UserName = FindViewById<EditText>(Resource.Id.UserName);
           	EditText Pass = FindViewById<EditText>(Resource.Id.Password);
            
		Button log = FindViewById<Button>(Resource.Id.Log);
		log.Click += delegate
		{
			
                	if(UserName.Text.Equals("inbar") && Pass.Text.Equals("king"))
                	{
                   		Toast.MakeText(this,"Login Done",ToastLength.Long).Show();
				StartActivity(typeof(ActivityItems));
                	}
		
            	};
        }
    }
}
