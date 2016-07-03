using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace anesthesiaconsiderations_Android
{
    [Activity(Label = "anesthesiaconsiderations_Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Navigation Buttions
            // About Button
            Button button1 = FindViewById<Button>(Resource.Id.button1);
            // Emergencies Button 
            Button button2 = FindViewById<Button>(Resource.Id.button2);
            // Considerations Button 
            Button button3 = FindViewById<Button>(Resource.Id.button3);
            // Legal Button
            Button button4 = FindViewById<Button>(Resource.Id.button4);
        }
    }
}

