using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class FatEmbolism : ContentPage
    {
        public FatEmbolism()
        {
            Label header = new Label
            {
                Text = "FatEmbolism",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Fat Embolism",

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
