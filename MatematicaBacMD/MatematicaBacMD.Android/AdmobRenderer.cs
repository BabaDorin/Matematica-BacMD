
using Android.Content;
using Android.Gms.Ads;
using MatematicaBacMD.Controls;
using MatematicaBacMD.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using System.Diagnostics;


[assembly: ExportRenderer(typeof(AdmobControl), typeof(AdMobRenderer))]
namespace MatematicaBacMD.Droid
{
    public class AdMobRenderer : ViewRenderer<AdmobControl, AdView>
    {
        public AdMobRenderer(Context context) : base(context)
        {
        }

        private int GetSmartBannerDpHeight()
        {
            var dpHeight = Resources.DisplayMetrics.HeightPixels / Resources.DisplayMetrics.Density;

            if (dpHeight <= 400)
            {
                return 40;
            }
            if (dpHeight <= 720)
            {
                return 62;
            }
            return 102;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<AdmobControl> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                var adView = new AdView(Context)
                {
                    AdSize = AdSize.SmartBanner,
                    AdUnitId = Element.AdUnitId
                };

                adView.AdListener = new AdListener(e);
                var requestbuilder = new AdRequest.Builder();
                adView.LoadAd(requestbuilder.Build());
                e.NewElement.HeightRequest = GetSmartBannerDpHeight();

                SetNativeControl(adView);
            }
        }
    }

    class AdListener : Android.Gms.Ads.AdListener
    {
        ElementChangedEventArgs<AdmobControl> e;
        public AdListener(ElementChangedEventArgs<AdmobControl> e)
        {
            this.e = e;
        }

        public override void OnAdFailedToLoad(int p0)
        {
            base.OnAdFailedToLoad(p0);
            System.Diagnostics.Debug.WriteLine("Failed");
            e.NewElement.HeightRequest = 0;
        }
    }
}
