using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Views.InputMethods;

namespace anesthesiaconsiderations_Android
{
    [Activity(Label = "anesthesiaconsiderations_Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button aboutButton;
        Button considerationsButton;
        Button emergenciesButton;
        Button legalButton;

        LinearLayout mLinearLayout;
        
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            mLinearLayout = FindViewById<LinearLayout>(Resource.Id.Main);

            aboutButton = FindViewById<Button>(Resource.Id.button1);
            considerationsButton = FindViewById<Button>(Resource.Id.button3);
            emergenciesButton = FindViewById<Button>(Resource.Id.button2);
            legalButton = FindViewById<Button>(Resource.Id.button4);

            aboutButton.Click += aboutButton_Click;
            considerationsButton.Click += considerationsButton_Click;
            emergenciesButton.Click += emergenciesButton_Click;
            legalButton.Click += legalButton_Click;
            
            mLinearLayout.Click += mRelativeLayout_Click;

        }

        void aboutButton_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(About));
            this.StartActivity(intent);
        }

        void considerationsButton_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Considerations));
            this.StartActivity(intent);
        }

        void emergenciesButton_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Emergencies));
            this.StartActivity(intent);
        }

        void legalButton_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Legal));
            this.StartActivity(intent);
        }

        void mRelativeLayout_Click(object sender, EventArgs e)
        {
            InputMethodManager inputManager = (InputMethodManager)this.GetSystemService(Activity.InputMethodService);
            inputManager.HideSoftInputFromWindow(this.CurrentFocus.WindowToken, HideSoftInputFlags.None);
        }

    }
}

