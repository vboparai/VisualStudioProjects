using Xamarin.Forms;
using System;

namespace Images
{
    public partial class ImagesPage : ContentPage
    {
        public ImagesPage()
        {
            InitializeComponent();

            var imageSource = new UriImageSource { Uri = new Uri("http://lorempixel.com/1920/1080/sports/7/") };

            imageSource.CachingEnabled = false;
            image.Source = imageSource;



        }
    }
}
