using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FFImageLoading.Forms;

namespace MatematicaBacMD.Views.Exercitii
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class exDerivate : ContentPage
	{
		public exDerivate ()
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