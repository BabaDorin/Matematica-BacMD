using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
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
            img1.Source = ImageSource.FromFile("i22.jpg");
            img2.Source = ImageSource.FromFile("i23.jpg");
            img3.Source = ImageSource.FromFile("i24.jpg");
            img4.Source = ImageSource.FromFile("i25.jpg");
            img5.Source = ImageSource.FromFile("i26.jpg");
            img6.Source = ImageSource.FromFile("i27.jpg");
            var stack = Navigation.NavigationStack.ToList();
            Debug.WriteLine("stack = " + stack.Count());
        }
    }
}