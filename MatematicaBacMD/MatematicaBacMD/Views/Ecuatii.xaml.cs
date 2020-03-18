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
	public partial class Ecuatii : ContentPage
	{
		public Ecuatii ()
		{
			InitializeComponent ();
            img1.Source = ImageSource.FromFile("i22.png");
            img2.Source = ImageSource.FromFile("i23.png");
            img3.Source = ImageSource.FromFile("i24.png");
            img4.Source = ImageSource.FromFile("i25.png");
            img5.Source = ImageSource.FromFile("i26.png");
            img6.Source = ImageSource.FromFile("i234.png");
        }
	}
}