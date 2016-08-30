using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class AbdominalCompartmentSyndrome : ContentPage
    {
        public AbdominalCompartmentSyndrome()
        {
            Label header = new Label
            {
                Text = "Abdominal Compartment Syndrome",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Abdominal Compartment Syndrome",

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