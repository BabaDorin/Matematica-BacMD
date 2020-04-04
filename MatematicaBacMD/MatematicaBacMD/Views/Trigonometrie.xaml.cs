﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MatematicaBacMD.Views.Exercitii;

namespace MatematicaBacMD.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Trigonometrie : ContentPage
	{
		public Trigonometrie ()
		{
			InitializeComponent ();
            AdusMadus.AdUnitId = AppConstants.BannerId;
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FormuleTrigonometrie());
        }

        async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new exTrigonometrie());
        }
    }
}