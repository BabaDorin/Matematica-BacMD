﻿using System;
using Xamarin.Forms;
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
            AdusMadus.AdUnitId = AppConstants.BannerId;
            //AdusMadus3.AdUnitId = AppConstants.BannerId;
            AdusMadus3.AdUnitId = AppConstants.BannerId;
            
            //if (AdusMadus == null)
            //    AdusMadus.HeightRequest = 0;
            //layyy.Children.Add(admobControl);
            //Content = new StackLayout()
            //{
            //    Children = { adLabel, admobControl}
            //};

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

        async void btnPolinoame(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Polinoame());
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
        async void btnTeoriaProbabilitatilor(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TeoriaProbabilitatilor());
        }

        async void btnCalculFinanciar(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CalculFinanciar());
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

        async void btnPoligoane(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Poligoane());
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

    }
}
