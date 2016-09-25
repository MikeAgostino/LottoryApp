using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using LottoryApp.Activities;

namespace LottoryApp
{
    [Activity(Label = "Number Generator", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button CanLottoButton = FindViewById<Button>(Resource.Id.CanLotto);
            CanLottoButton.Click += delegate { StartActivity(typeof(CanLotto));};

            Button USLottoButton = FindViewById<Button>(Resource.Id.USLotto);
            USLottoButton.Click += delegate { StartActivity(typeof(USLotto)); };

           // Button CustomLottoButton = FindViewById<Button>(Resource.Id.CustomLotto);
            //CustomLottoButton.Click += delegate { StartActivity(typeof(CustomLotto)); };
        }
    }
}

