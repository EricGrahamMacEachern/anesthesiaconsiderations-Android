using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class PostoperativeVisualLoss : ContentPage
    {
        public PostoperativeVisualLoss()
        {
            Label header = new Label
            {
                Text = "Postoperative Visual Loss ",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Postoperative Visual Loss ",

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
