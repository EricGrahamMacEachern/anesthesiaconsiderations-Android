using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class TransfusionReactions : ContentPage
    {
        public TransfusionReactions()
        {
            Label header = new Label
            {
                Text = "Transfusion Reactions",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Transfusion Reactions",

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
