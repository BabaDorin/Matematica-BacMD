using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MatematicaBacMD.Views.Exercitii;

namespace MatematicaBacMD.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SiruriNumerice : ContentPage
    {
		public SiruriNumerice ()
		{
			InitializeComponent ();
            AdusMadus.AdUnitId = AppConstants.BannerId;
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new exSiruriNumerice());
        }
    }
}