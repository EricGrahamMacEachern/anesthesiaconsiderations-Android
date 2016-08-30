using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class DelayedEmergence : ContentPage
    {
        public DelayedEmergence()
        {
            Label header = new Label
            {
                Text = "Delayed Emergence",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "Differential Diagnosis ('DIMS')" +

"Drugs" +
"Anesthesia related:" +
"Sedatives & narcotics" +
"Residual paralysis, pseudocholinesterase deficiency" +
"Drug error" +
"Non-anesthesia related:" +
"Street drugs, alcohol" +
"Herbal medicines (valerian root, St. John's wort)" +
"Infection:" +
"Encephalitis, meningitis" +
"Sepsis" +
"Metabolic:" +
"Hypoxia" +
"Hypercarbia" +
"Electrolyte abnormalities" +
"Hypoglycemia or hyperglycemia (DKA or HONK)" +
"Hypothermia" +
"Uremia" +
"Hepatic encephalopathy" +
"Osmolality problems" +
"Myxedema coma" +
"Structural:" +
"Stroke (ischemic or hemorrhagic)" +
"Hydrocephalus" +
"Diffuse anoxic injury" +
"Cerebral edema" +
"Seizure or post-ictal" +
"Pneumocephalus" +
"Cerebral hyperperfusion syndrome (post carotid endarterectomy)" +


"Management" +

"Scan monitors: HR, ECG, rhythm, EtCO2, SpO2, BP, temp" +
"Ensure stability of ABC's" +
"Confirm reversal of paralysis" +
"Review all drugs administered & syringes for drug error" +
"Focused physical exam:" +
"Neurological: GCS, pupils, gag/cough, symmetric motor movement, focal signs" +
"Cardiorespiratory: adequacy of perfusion" +
"Blood work:" +
"CBC, lytes, urea, creatinine, glucometer, osmolality, ABG with lactate & ionized calcium" +
"Liver enzymes, bilirubin" +
"Toxicology screen" +
"TSH, FT4" +
"Consider: Neurology / ICU consultation, CT head, EEG, lumbar puncture" +
"Empiric therapy:" +
"Glucose: 25-50 cc of D50 or 250 cc of D10" +
"Thiamine 100 mg IV" +
"Opioid reversal: naloxone 0.04 mg IV q 2 mins, up to 2mg" +
"Benzodiazepine reversal: flumazenil 0.2-1 mg IV q 1 min, up to 1mg" +
"Physostigmine (0.5 to 1 mg IV) counteracts but does not reverse sedation caused by inhalation anesthetics, other sedatives, & anticholinergics",

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
