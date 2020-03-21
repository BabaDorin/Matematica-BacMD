using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.ComponentModel;
using System.Diagnostics;
using MatematicaBacMD.Views;
using FFImageLoading.Forms;
using System.Reflection;

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

        async void btnPutere(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Putere());
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
            //App.Current.MainPage = new Ecuatii();
            await Navigation.PushAsync(new Ecuatii());
        }

        async void btnInecuatii(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Inecuatii());
        }

        async void btnTrigonometrie(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Trigonometrie());
        }
        async void btnSiruriNumerice(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SiruriNumerice());
        }

        async void btnNumereComplexe(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NumereComplexe());
        }

        async void btnMatrici(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Matrici());
        }

        async void btnLimite(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Limite());
        }

        async void btnDerivateleFunctiilor(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DerivateleFunctiilor());
        }

        async void btnIntegrale(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Integrale());
        }

        async void btnPrimitiveleFunctiilor(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PrimitiveleFunctiilor());
        }

        async void btnTeoriaProbabilitatilor(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TeoriaProbabilitatilor());
        }

        async void btnStatistica(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Statistica());
        }

        async void btnTriunghiul(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Triunghiul());
        }

        async void btnParalelogramul(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Paralelogramul());
        }

        async void btnTrapezul(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Trapezul());
        }

        async void btnThales(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Thales());
        }

        async void btnPoligoane(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Poligoane());
        }

        async void btnAriiFiguriPlane(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AriiFiguriPlane());
        }

        async void btnParalelism(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Paralelism());
        }

        async void btnPerpendicularitate(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Perpendicularitate());
        }

        async void btnPrisma(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Prisma());
        }

        async void btnPiramida(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Piramida());
        }

        async void btnTrunchiPiramida(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TrunchiPiramida());
        }

        async void btnCilindru(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Cilindru());
        }

        async void btnCon(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Conul());
        }

        async void btnTrunchiCon(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TrunchiCon());
        }

        async void btnSfera(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sfera());
        }

        async void btnVolumPoliedre(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VolumPoliedre());
        }

    }
}
