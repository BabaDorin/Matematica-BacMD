using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.ComponentModel;
using System.Diagnostics;
using MatematicaBacMD.Views;

namespace MatematicaBacMD
{
    public partial class MainPage : ContentPage
    {
        //Color pallete:
        //Albastru inchis: 5680E9 (navbar)
        //Albastru deschis - 84CEEB
        //Alastry mediu: 5AB9EA
        //Bej C1C8E4
        //Violet 8860D0
        public MainPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }

        async void btnMultimi(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Multimi());
        }

        async void btnCombinatorica(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Combinatorica());
        }

        async void btnRadicali(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Radicali());
        }

        async void btnLogaritmi(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Logaritmi());
        }

        async void btnFunctii(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Functii());
        }

        async void btnEcuatii(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Functii());
        }



    }
}
