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

namespace LottoryApp
{
    [Activity(Label = "CustomLotto")]
    public class CustomLotto : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.CustomLotto);

            Button generateCustomLotto = FindViewById<Button>(Resource.Id.GenerateCustom);
            generateCustomLotto.Click += delegate
            {
                Intent NumbersScreen = new Intent(this, typeof(NumbersScreen));
                NumbersScreen.PutExtra("lowerLimit", FindViewById<EditText>(Resource.Id.LowerLimit).Text);
                NumbersScreen.PutExtra("upperLimit", FindViewById<EditText>(Resource.Id.UpperLimit).Text);
                NumbersScreen.PutExtra("totalNumbers", FindViewById<EditText>(Resource.Id.TotalNumbers).Text);
                NumbersScreen.PutExtra("totalBonusNumbers", FindViewById<EditText>(Resource.Id.TotalBonusNumbers).Text);
                NumbersScreen.PutExtra("LowerBonusLimit", FindViewById<EditText>(Resource.Id.LowerBonusLimit).Text);
                NumbersScreen.PutExtra("UpperBonusLimit", FindViewById<EditText>(Resource.Id.UpperBonusLimit).Text);
                StartActivity(NumbersScreen);
            };
        }
    }
}