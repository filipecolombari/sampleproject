using System;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Syncfusion.Charts;
using Android.OS;

namespace XamarinForms.Pim.Droid
{
    [Activity(Label = "XamarinForms.Pim",Icon = "@drawable/icon",Theme = "@style/MainTheme",ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity :global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            
            base.OnCreate(bundle);
            Window.SetSoftInputMode(Android.Views.SoftInput.AdjustResize);
            if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
            {
                // Bug in Android 5+, this is an adequate workaround
                AndroidBug5497WorkaroundForXamarinAndroid.assistActivity(this);
            }

            global::Xamarin.Forms.Forms.Init(this,bundle);
            LoadApplication(new App());
        }

    }
}

