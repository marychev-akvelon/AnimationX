﻿using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace AnimationX.UITest
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                // return ConfigureApp.Android.StartApp();
                return ConfigureApp.Android.InstalledApp("com.companyname.animationx").StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}