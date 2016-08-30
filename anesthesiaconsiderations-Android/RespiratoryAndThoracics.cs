using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class RespiratoryAndThoracics : ContentPage
    {
        public RespiratoryAndThoracics()
        {
            Label header = new Label
            {
                Text = "Respiratory & Thoracics",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Respiratory & Thoracics",

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
