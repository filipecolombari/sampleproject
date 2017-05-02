using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using KeyboardOverlap.Forms.Plugin.iOSUnified;
using Xamarin.Forms;
using Syncfusion.SfChart.XForms.iOS.Renderers;

namespace XamarinForms.Pim.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate :global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app,NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            KeyboardOverlapRenderer.Init();

            var corSW = UIColor.FromRGB(140,198,63);

            UINavigationBar.Appearance.BackgroundColor = corSW;
            UINavigationBar.Appearance.TintColor = UIColor.White;
            UINavigationBar.Appearance.BarTintColor = corSW;
            UINavigationBar.Appearance.SetBackgroundImage(new UIImage(),UIBarPosition.Any,UIBarMetrics.Default);
            UINavigationBar.Appearance.ShadowImage = new UIImage();
            UINavigationBar.Appearance.SetTitleTextAttributes(new UITextAttributes()
            {
                TextColor = UIColor.White
            });

            UITabBar.Appearance.BackgroundColor = corSW;
            UITabBar.Appearance.BarTintColor = corSW;
            UITabBar.Appearance.TintColor = UIColor.White;

            UIDatePicker.Appearance.TintColor = UIColor.Gray;

            new SfChartRenderer();

            LoadApplication(new App());

            return base.FinishedLaunching(app,options);

        }
    }
}
