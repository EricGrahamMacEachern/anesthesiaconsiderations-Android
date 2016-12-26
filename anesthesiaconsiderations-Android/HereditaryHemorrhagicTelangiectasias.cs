using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class HereditaryHemorrhagicTelangiectasias : ContentPage
    {
        public HereditaryHemorrhagicTelangiectasias()
        {
            Label header = new Label
            {
                Text = "Hereditary Hemorrhagic Telangiectasias 404",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Hereditary Hemorrhagic Telangiectasias 404",

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