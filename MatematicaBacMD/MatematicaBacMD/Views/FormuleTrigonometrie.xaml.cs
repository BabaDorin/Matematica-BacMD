
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MatematicaBacMD.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FormuleTrigonometrie : ContentPage
	{
		public FormuleTrigonometrie ()
		{
			InitializeComponent ();
            AdusMadus.AdUnitId = AppConstants.BannerId;
        }
	}
}