﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MatematicaBacMD.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Trigonometrie : ContentPage
	{
		public Trigonometrie ()
		{
			InitializeComponent ();
		}

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FormuleTrigonometrie());
        }
    }
}