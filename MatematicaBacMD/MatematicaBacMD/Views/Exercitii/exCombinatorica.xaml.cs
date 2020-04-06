using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MatematicaBacMD.Views.Exercitii
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class exCombinatorica : ContentPage
	{
		public exCombinatorica ()
		{
			InitializeComponent ();
            AdusMadus.AdUnitId = AppConstants.BannerId;
        }

        async void btnLoad(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new exTeoriaProbabilitatilor());
        }
    }
}