using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class ExtravasationInjuries : ContentPage
    {
        public ExtravasationInjuries()
        {
            Label header = new Label
            {
                Text = "Extravasation Injuries",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Extravasation Injuries",

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
