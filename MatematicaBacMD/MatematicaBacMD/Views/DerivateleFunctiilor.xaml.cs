﻿using MatematicaBacMD.Views.Exercitii;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MatematicaBacMD.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DerivateleFunctiilor : ContentPage
	{
		public DerivateleFunctiilor ()
		{
			InitializeComponent ();
            AdusMadus.AdUnitId = AppConstants.BannerId;
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new exDerivate());
        }
    }
}