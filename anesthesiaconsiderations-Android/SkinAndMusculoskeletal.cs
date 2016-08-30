using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class SkinAndMusculoskeletal : ContentPage
    {
        public SkinAndMusculoskeletal()
        {
            Label header = new Label
            {
                Text = "Skin & Musculoskeletal",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Skin & Musculoskeletal",

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
