﻿
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MatematicaBacMD.Views.Exercitii
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class exPolinoame : ContentPage
	{
		public exPolinoame ()
		{
			InitializeComponent ();
            AdusMadus.AdUnitId = AppConstants.BannerId;
        }
	}
}