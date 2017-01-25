using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace Rbay
{
	[Activity (Label = "ActivityItems")]
	public class ActivityItems : Activity
	{
		
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			SetContentView(Resource.Layout.LayoutItems);
			
			// Create your application here
			TextView DDosCost = FindViewById<TextView>(Resource.Id.DDosCost);
			EditText DDosNum = FindViewById<EditText>(Resource.Id.DDosNum);
			Button ready = FindViewById<Button>(Resource.Id.ReadyButton);
			int cost=0;
			ready.Click += delegate {
				cost = int.Parse(DDosNum.Text) * 10;
				DDosCost.Text = ""+cost;
			};

		}
	}
}
