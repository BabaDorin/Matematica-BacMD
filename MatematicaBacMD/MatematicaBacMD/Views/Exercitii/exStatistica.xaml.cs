
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MatematicaBacMD.Views.Exercitii
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class exStatistica : ContentPage
	{
		public exStatistica ()
		{
			InitializeComponent ();
            AdusMadus.AdUnitId = AppConstants.BannerId;
        }
	}
}