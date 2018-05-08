using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
    public partial class GreetPage : ContentPage
    {
        public GreetPage()
        {
            InitializeComponent();

            slider.Value = 0.5;

            var x = new OnPlatform<Thickness>
            {
                Android = new Thickness(0),
                iOS = new Thickness(0, 20, 0, 0)
            };

            Padding = x;

            //if(Device.OS == TargetPlatform.iOS)
            //{
            //    Padding = new Thickness(0, 20, 0, 0);

            //} else if (Device.OS == TargetPlatform.Android)
            //{
            //    Padding = new Thickness(10, 20, 0, 0);

            //} else if (Device.OS == TargetPlatform.WinPhone)
            //{
            //    Padding = new Thickness(30, 20, 0, 0);
            //}

            //Padding = Device.OnPlatform(
            //    iOS: new Thickness(0, 20, 0, 0),
            //    Android: new Thickness(0, 20, 0, 0),
            //    WinPhone: new Thickness(0, 20, 0, 0)
            //);

            //Device.OnPlatform(
            //    iOS: () => {
            //        Padding = new Thickness(0, 20, 0, 0);
            //},
            //    Android: () => {
            //    Padding = new Thickness(10, 20, 0, 0);
            //}
            
            //);


        }
    
     
    }
}
