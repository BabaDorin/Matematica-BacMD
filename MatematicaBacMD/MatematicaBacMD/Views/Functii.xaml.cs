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
            var assebly = typeof(MainPage);
            //image = new FFImageLoading.Forms.CachedImage()
            //{
            //    //CacheDuration = TimeSpan.FromHours(1),
            //    //DownsampleToViewSize = true,
            //    //RetryCount = 0,
            //    //BitmapOptimizations = true,
            //    //Source = ImageSource.FromResource("MatematicaBacMD.Images.i31.jpg", assebly)
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.Center,
            //    WidthRequest = 300,
            //    HeightRequest = 300,
            //    CacheDuration = TimeSpan.FromDays(30),
            //    DownsampleToViewSize = true,
            //    RetryCount = 0,
            //    RetryDelay = 250,
            //    BitmapOptimizations = false,
            //    Source = "http://loremflickr.com/600/600/nature?filename=simple.jpg"
            //};
            //img = 
            //img1.Source = ImageSource.FromResource("MatematicaBacMD.Images.i31.jpg", assebly);
            //img2.Source = ImageSource.FromResource("MatematicaBacMD.Images.i31.jpg", assebly);
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
    }
}