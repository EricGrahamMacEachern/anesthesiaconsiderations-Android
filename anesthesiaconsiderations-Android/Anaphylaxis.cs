using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class Anaphylaxis : ContentPage
    {
        public Anaphylaxis()
        {
            Label header = new Label
            {
                Text = "Anaphylaxis",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Anaphylaxis",

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
