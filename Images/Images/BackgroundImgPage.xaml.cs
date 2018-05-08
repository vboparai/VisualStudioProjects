using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Images
{
    public partial class BackgroundImgPage : ContentPage
    {
        public BackgroundImgPage()
        {
            InitializeComponent();

            image2.Source = ImageSource.FromResource("Images.img.background.jpg");

        }
    }
}
