using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Lists.Models;
using Xamarin.Forms;

namespace Lists
{
	public partial class GroupItemsPage : ContentPage
	{
		void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
		{
			listView3.ItemsSource = GetContacts(e.NewTextValue);
		}

		IEnumerable<Contact> GetContacts(string searchText = null)
		{
			var contacts = new List<Contact>{
                                
                new Contact { Name = "Parth", ImageUrl = "http://lorempixel.com/100/100/people/2/", Status = "Hey, let's talk!" },

                new Contact { Name = "Varinder", ImageUrl = "http://lorempixel.com/100/100/people/1/" }
			};

			if (String.IsNullOrWhiteSpace(searchText))
				return contacts;
            
			return contacts.Where(c => contacts.Name.StartsWith(searchText));
		}

		void Handle_Refreshing(object sender, System.EventArgs e)
		{
			listView3.ItemsSource = GetContacts();

			listView3.EndRefresh();
		}

		private ObservableCollection<Contact> _contacts;

		void Delete_Clicked(object sender, System.EventArgs e)
		{
			var contact = (sender as MenuItem).CommandParameter as Contact;
			_contacts.Remove(contact);
		}

		void Call_Clicked(object sender, System.EventArgs e)
		{
			var menuItem = sender as MenuItem;
			var contact = menuItem.CommandParameter as Contact;
			DisplayAlert("Call", contact.Name, "OK");
		}
        
		public GroupItemsPage()
        {
            InitializeComponent();

			listView3.ItemsSource = GetContacts();
                     
        }
	}
}
