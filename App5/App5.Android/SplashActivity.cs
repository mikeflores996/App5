﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App5.Droid
{
    [Activity(Label = "SplashActivity",
                Theme = "@style/SplashTheme",
                MainLauncher = true,
                NoHistory = true,
                ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]

    
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            StartActivity(typeof(MainActivity));
        }
    }
}