﻿using MatematicaBacMD.Views.Exercitii;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MatematicaBacMD.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TrunchiCon : ContentPage
	{
		public TrunchiCon ()
		{
			InitializeComponent ();
            AdusMadus.AdUnitId = AppConstants.BannerId;
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new exTrunchiCon());
        }
    }
}