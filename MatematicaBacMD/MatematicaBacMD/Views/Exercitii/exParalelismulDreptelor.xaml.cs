﻿
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MatematicaBacMD.Views.Exercitii
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class exParalelismulDreptelor : ContentPage
	{
		public exParalelismulDreptelor ()
		{
			InitializeComponent ();
            AdusMadus.AdUnitId = AppConstants.BannerId;
        }
	}
}