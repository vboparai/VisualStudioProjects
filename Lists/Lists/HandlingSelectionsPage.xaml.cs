using System;
using System.Collections.Generic;
using Lists.Models;
using Xamarin.Forms;

namespace Lists
{
    public partial class HandlingSelectionsPage : ContentPage
    {
		void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			var contact = e.SelectedItem as Contact;
			DisplayAlert("Selected", contact.Name, "OK");
		}

		void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
		{
			var contact = e.Item as Contact;
			DisplayAlert("Tapped", contact.Name, "OK");
		}

        public HandlingSelectionsPage()
        {
            InitializeComponent();

			listView4.ItemsSource = new List<ContactGroup>{

                new ContactGroup("P", "P"){
                    new Contact { Name = "Parth", ImageUrl = "http://lorempixel.com/100/100/people/2/", Status = "Hey, let's talk!" }
                },

                new ContactGroup("V", "V"){
                    new Contact { Name = "Varinder", ImageUrl = "http://lorempixel.com/100/100/people/1/" }
                },

            };
        }
        
    }
}
