
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MatematicaBacMD.Views.Exercitii
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class exSfera : ContentPage
	{
		public exSfera ()
		{
			InitializeComponent ();
            AdusMadus.AdUnitId = AppConstants.BannerId;
        }
	}
}