﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MatematicaBacMD.Views.Exercitii
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class exPerpendicularitate : ContentPage
	{
		public exPerpendicularitate ()
		{
			InitializeComponent ();
            AdusMadus.AdUnitId = AppConstants.BannerId;
        }
	}
}