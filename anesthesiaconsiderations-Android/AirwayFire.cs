using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class AirwayFire : ContentPage
    {
        public AirwayFire()
        {
            Label header = new Label
            {
                Text = "Airway Fire",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Management\n\n" +

"Inform team & call for help" +
"Simultaneously remove the endotracheal tube (ETT) & stop gases/disconnect circuit" +
"Pour saline or water into airway" +
"Remove airway foreign bodies (ie: ETT pieces, sponges)" +
"When fire is extinguished: re-establish ventilation; avoid supplemental oxygen if possible" +
"Consider prompt reintubation prior to swelling & coordinated with bronchoscopy" +
"Examine entire airway (including bronchoscopy) to assess injury & remove residual debris" +


"Prevention\n\n" +

"For high risk procedures:\n" +
"Discuss fire prevention & management with team during time-out" +
"Avoid FiO2 > 0.3 & avoid N2O" +

"For laser surgery of vocal cord or larynx:\n" +
"Use laser resistant ETT (single or double cuff)" +
"Assure ETT cuff sufficiently deep below vocal cords" +
"Fill proximal ETT cuff with methylene blue-tinted saline (acts as a marker if cuff perforated by laser)" +
"Ensure laser in STANDBY when not in active use" +
"Surgeon protects ETT cuff with wet gauze" +
"Surgeon confirms FiO2 < 0.3 & no N2O prior to laser use (may require several minutes to dilute FiO2 & FeO2 to <0.3 depending on fresh gas flow & initial FiO2)" +

"For non-laser surgery in oropharynx:\n" +
"Regular PVC ETT may be used" +
"Consider packing wet gauze around ETT to minimize O2 leakage" +
"Consider continuous suctioning of the operating field inside oropharynx",

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
