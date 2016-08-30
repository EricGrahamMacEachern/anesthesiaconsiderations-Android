﻿using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class RigidBronchoscopy : ContentPage
    {
        public RigidBronchoscopy()
        {
            Label header = new Label
            {
                Text = "Rigid Bronchoscopy",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Rigid Bronchoscopy",

                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                }
            };



            // Build the page.
            this.Content = new StackLayout
            {
                Children =
                {
                    header,
                    scrollView,
                }
            };
        }
    }
}
