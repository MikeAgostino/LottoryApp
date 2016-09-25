
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using LottoryApp.Utilities;
using Android.Gms.Ads;

namespace LottoryApp
{
    [Activity(Label = "")]
    public class NumbersScreen : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);



            // Create your application here
            SetContentView(Resource.Layout.NumbersScreen);

            AdView adView = FindViewById<AdView>(Resource.Id.NumAdView);
            AdRequest adRequest = new AdRequest.Builder().Build();
            adView.LoadAd(adRequest);

            var Numbers = FindViewById<TextView>(Resource.Id.Numbers);
            Numbers.Text = LottoryHelper.GenerateNumbers(Intent.GetIntExtra("lowerLimit", 0),Intent.GetIntExtra("upperLimit", 0), Intent.GetIntExtra("totalNumbers", 0), Intent.GetIntExtra("totalBonusNumbers", 0), Intent.GetIntExtra("bonusLowerLimit", 0), Intent.GetIntExtra("bonusUpperLimit", 0));
            var GoodluckText = FindViewById<TextView>(Resource.Id.GoodLuck);
            GoodluckText.Text = "Good Luck!";
        }
    }
}