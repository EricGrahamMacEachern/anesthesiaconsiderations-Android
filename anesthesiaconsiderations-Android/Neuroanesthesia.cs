using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class Neuroanesthesia : ContentPage
    {
        public Neuroanesthesia()
        {
            Label header = new Label
            {
                Text = "Neuroanesthesia",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Neuroanesthesia",

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
