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
                    Text = "Signs" +

"Rash/hives" +
"Angioedema" +
"Hypotension" +
"Tachycardia" +
"Hypoxemia" +
"Bronchospasm/wheezing" +
"peak inspiratory pressure" +


"Management" +

"Stop offending agent" +
"Inform surgeon, call for help" +
"Discontinue or ↓ all anesthetic agents" +
"Airway:" +
"100% O2" +
"Secure airway" +
"Administer epinephrine IV in escalating doses:" +
"Start at 10-100 mcg & ↑ as necessary until clinical improvement" +
"Consider early epinephrine infusion (start at 2-20mcg/min)" +
"Aggressive fluid resuscitation (many require several litres)" +
"Bronchospasm: salbutamol PRN" +
"Give secondary medications:" +
"H1 antagonist: diphenhydramine 25-50mg IV" +
"H2 antagonist: ranitidine 50mg IV" +
"Methylprednisolone 1-2mg/kg IV per day OR dexamethasone 20mg IV" +
"Start invasive lines: arterial line, central line" +
"Refractory hypotension despite epinephrine:" +
"Vasopressin 1-40 unit bolus, 0.01-0.04 units/min infusion" +
"Glucagon 1-2 mg over 5 min IV then 5-15 mcg/min IV infusion (especially for patients taking beta blockers; inotropic & chronotropic effects not mediated through beta receptors)" +
"Methylene blue 1-2mg/kg IV (inhibits nitric oxide synthase & guanylate cyclase)" +
"Consider bicarbonate (0.5-1 mEq/kg) with acidosis" +
"Consider transesophageal echocardiography (TEE) & entertain other differential diagnosis" +
"Post-event care:" +
"Laboratory tests to support diagnosis:" +
"Serum tryptase levels 15 minutes - 3 hours after onset of symptoms" +
"Serum histamine levels peak 5 - 15 minutes after onset of symptoms; return to baseline at 60 minutes" +
"Discharge to ICU intubated & ventilated" +
"Due to biphasic nature, monitor at least 24 hours" +
"Consult allergist",

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
