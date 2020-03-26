using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MatematicaBacMD.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Load : ContentPage
	{
		public Load ()
		{
			InitializeComponent ();
		}

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if (img1.Source == null)
            {
                img1.HeightRequest = 110;
                img1.WidthRequest = 110;
                img1.Source = "i44.jpg";
            }
            else
            {
                img1.HeightRequest = 0;
                img1.WidthRequest = 0;
                img1.Source = null;
            }
        }
    }
}