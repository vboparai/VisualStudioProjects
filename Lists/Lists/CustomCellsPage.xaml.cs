using System;
using System.Collections.Generic;
using Lists.Models;
using Xamarin.Forms;

namespace Lists
{
    public partial class CustomCellsPage : ContentPage
    {
        public CustomCellsPage()
        {
            InitializeComponent();

			listView2.ItemsSource = new List<Contact>{
                new Contact { Name = "Varinder", ImageUrl = "http://lorempixel.com/100/100/people/1/" },
                new Contact { Name = "Parth", ImageUrl = "http://lorempixel.com/100/100/people/2/", Status = "Hey, let's talk!" }
            };
        }
    }
}
