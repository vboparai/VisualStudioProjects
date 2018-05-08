﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Layouts
{
    public partial class GridPage : ContentPage
    {
        public GridPage()
        {
            InitializeComponent();

            var grid = new Grid
            {
                RowSpacing = 20,
                ColumnSpacing = 40
            };

            var label = new Label { Text = "Label 1" };
            grid.Children.Add(label, 0, 0);
            Grid.SetRowSpan(label, 2);

            grid.RowDefinitions.Add(new RowDefinition
            {
                Height = new GridLength(100, GridUnitType.Absolute)
            });

            grid.RowDefinitions.Add(new RowDefinition
            {
                Height = new GridLength(2, GridUnitType.Star)
            });

            grid.RowDefinitions.Add(new RowDefinition
            {
                Height = new GridLength(1, GridUnitType.Auto)
            });

            Content = grid;

        }
    }
}
