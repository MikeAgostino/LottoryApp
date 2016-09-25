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
using Android.Gms.Ads;

namespace LottoryApp.Activities
{
    [Activity(Label = "American Lotteries")]
    public class USLotto : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);



            SetContentView(Resource.Layout.USLotto);

            AdView adView = FindViewById<AdView>(Resource.Id.USAdView);
            AdRequest adRequest = new AdRequest.Builder().Build();
            adView.LoadAd(adRequest);

            Button powerBall = FindViewById<Button>(Resource.Id.PowerBallButton);
            powerBall.Click += delegate
            {
                var NumberActivity = new Intent(this, typeof(NumbersScreen));
                NumberActivity.PutExtra("lowerLimit", 1);
                NumberActivity.PutExtra("upperLimit", 69);
                NumberActivity.PutExtra("bonusLowerLimit", 1);
                NumberActivity.PutExtra("bonusUpperLimit", 26);
                NumberActivity.PutExtra("totalNumbers", 5);
                NumberActivity.PutExtra("totalBonusNumbers", 1);
                StartActivity(NumberActivity);
            };
            Button megaMillions = FindViewById<Button>(Resource.Id.MegaMillionsButton);
            megaMillions.Click += delegate
            {
                var NumberActivity = new Intent(this, typeof(NumbersScreen));
                NumberActivity.PutExtra("lowerLimit", 1);
                NumberActivity.PutExtra("upperLimit", 75);
                NumberActivity.PutExtra("bonusLowerLimit", 1);
                NumberActivity.PutExtra("bonusUpperLimit", 15);
                NumberActivity.PutExtra("totalNumbers", 5);
                NumberActivity.PutExtra("totalBonusNumbers", 1);
                StartActivity(NumberActivity);
            };

        }
    }
}