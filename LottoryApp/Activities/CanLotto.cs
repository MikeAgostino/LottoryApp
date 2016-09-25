
using Android.App;
using Android.Content;
using Android.Gms.Ads;
using Android.OS;
using Android.Widget;
using LottoryApp.Utilities;

namespace LottoryApp
{
    [Activity(Label = "Canadian Lotteries")]
    public class CanLotto : Activity
    {



        protected override void OnCreate(Bundle savedInstanceState)
        {



            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.CanLotto);

            AdView adView = FindViewById<AdView>(Resource.Id.CanAdView);
            AdRequest adRequest = new AdRequest.Builder().Build();
            adView.LoadAd(adRequest);


            Button Ont649 = FindViewById<Button>(Resource.Id.Ont649);

            Ont649.Click += delegate
            {
                var NumberActivity = new Intent(this, typeof(NumbersScreen));
                NumberActivity.PutExtra("lowerLimit", 1);
                NumberActivity.PutExtra("upperLimit", 49);
                NumberActivity.PutExtra("bonusLowerLimit", 1);
                NumberActivity.PutExtra("bonusUpperLimit", 49);
                NumberActivity.PutExtra("totalNumbers", 6);
                NumberActivity.PutExtra("totalBonusNumbers", 1);
                StartActivity(NumberActivity);

            };
            Button LottoMax = FindViewById<Button>(Resource.Id.LottoMax);

            LottoMax.Click += delegate
            {
                var NumberActivity = new Intent(this, typeof(NumbersScreen));
                NumberActivity.PutExtra("lowerLimit", 1);
                NumberActivity.PutExtra("upperLimit", 49);
                NumberActivity.PutExtra("bonusLowerLimit", 1);
                NumberActivity.PutExtra("bonusUpperLimit", 49);
                NumberActivity.PutExtra("totalNumbers", 7);
                NumberActivity.PutExtra("totalBonusNumbers", 1);
                StartActivity(NumberActivity);

            };
            Button Pick4 = FindViewById<Button>(Resource.Id.Pick4);

            Pick4.Click += delegate
            {
                var NumberActivity = new Intent(this, typeof(NumbersScreen));
                NumberActivity.PutExtra("lowerLimit", 0);
                NumberActivity.PutExtra("upperLimit", 9);
                NumberActivity.PutExtra("totalNumbers", 4);
                NumberActivity.PutExtra("totalBonusNumbers", 0);
                StartActivity(NumberActivity);

            };
            Button Pick3 = FindViewById<Button>(Resource.Id.Pick3);

            Pick3.Click += delegate
            {
                var NumberActivity = new Intent(this, typeof(NumbersScreen));
                NumberActivity.PutExtra("lowerLimit", 0);
                NumberActivity.PutExtra("upperLimit", 9);
                NumberActivity.PutExtra("totalNumbers", 3);
                NumberActivity.PutExtra("totalBonusNumbers", 0);
                StartActivity(NumberActivity);

            };
            Button Pick2 = FindViewById<Button>(Resource.Id.Pick2);

            Pick2.Click += delegate
            {
                var NumberActivity = new Intent(this, typeof(NumbersScreen));
                NumberActivity.PutExtra("lowerLimit", 0);
                NumberActivity.PutExtra("upperLimit", 9);
                NumberActivity.PutExtra("totalNumbers", 2);
                NumberActivity.PutExtra("totalBonusNumbers", 0);
                StartActivity(NumberActivity);

            };

        }

       
    }
}