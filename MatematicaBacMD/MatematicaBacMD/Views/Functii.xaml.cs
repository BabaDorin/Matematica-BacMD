using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Diagnostics;
using System.Reflection;

namespace MatematicaBacMD.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Functii : ContentPage
	{
		public Functii ()
		{
			InitializeComponent ();
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }

        private void Image_Error(object sender, FFImageLoading.Forms.CachedImageEvents.ErrorEventArgs e)
        {
            Debug.WriteLine("Error");
        }
    }
}