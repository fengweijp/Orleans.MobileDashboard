﻿using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Orleans.MobileDashboard.Droid
{
	[Activity (Label = "Orleans.MobileDashboard.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);

			LoadApplication (new App ());

			// reference themes
			var x = typeof (Xamarin.Forms.Themes.DarkThemeResources);
			x = typeof (Xamarin.Forms.Themes.LightThemeResources);
			x = typeof (Xamarin.Forms.Themes.Android.UnderlineEffect);
		}
	}
}

