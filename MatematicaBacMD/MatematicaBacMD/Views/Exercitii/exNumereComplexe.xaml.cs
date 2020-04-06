using FFImageLoading.Forms;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MatematicaBacMD.Views.Exercitii
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class exNumereComplexe : ContentPage
	{
		public exNumereComplexe ()
		{
			InitializeComponent ();
            AdusMadus.AdUnitId = AppConstants.BannerId;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var eve = e as TappedEventArgs;
            var barem = eve.Parameter as CachedImage;
            barem.IsVisible = !barem.IsVisible;
        }
    }
}