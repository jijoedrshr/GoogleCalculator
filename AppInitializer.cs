using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace EbayXamarinTest
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
               .Android
               //.InstalledApp("com.google.android.calculator")
                //.LaunchableActivity("com.android.calculator2.activities.MainActivity")
                .ApkFile(@"D:\EbayAPK\Calculator 7.8 (271241277).apk")
                .StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}