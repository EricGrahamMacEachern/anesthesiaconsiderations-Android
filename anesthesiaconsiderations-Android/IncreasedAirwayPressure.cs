using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class IncreasedAirwayPressure : ContentPage
    {
        public IncreasedAirwayPressure()
        {
            Label header = new Label
            {
                Text = "Increased Airway Pressure",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Increased Airway Pressure",

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
