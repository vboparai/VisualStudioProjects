﻿using System;
using System.Collections.Generic;
using Lists.Models;
using Xamarin.Forms;

namespace Lists.Models
{
	public class ContactGroup : List<Contact>
    {

		public string Title { get; set;  }
		public string ShortTitle { get; set; }

        public ContactGroup(string title, string shortTitle)
        {
			Title = title;
			ShortTitle = shortTitle;
        }
    }
}
