using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class VenousAirEmbolism : ContentPage
    {
        public VenousAirEmbolism()
        {
            Label header = new Label
            {
                Text = "Venous Air Embolism",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Local Anesthetic Toxicity",

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
