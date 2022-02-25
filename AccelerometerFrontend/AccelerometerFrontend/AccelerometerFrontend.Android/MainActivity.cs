using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;

namespace AccelerometerFrontend.Droid
{
    [Activity(Label = "AccelerometerFrontend", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTc3NjMwQDMxMzkyZTM0MmUzMEJTaEEzdzlKSk9xTFBpaEZCZXd4a3llTGxNQzhXN3ZXYVNncUpFZFpWUDg9");

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}