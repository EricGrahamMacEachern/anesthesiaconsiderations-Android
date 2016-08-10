using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class DelayedEmergence : ContentPage
    {
        public DelayedEmergence()
        {
            Label header = new Label
            {
                Text = "Delayed Emergence",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Delayed Emergence",

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
