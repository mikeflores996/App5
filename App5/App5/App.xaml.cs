using App5.NewFolder3;
using App5.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5
{
    public partial class App : Application
    {
        public Login Login { get; private set; }

        public App()
        {
            InitializeComponent();

            MainPage = new Start();
            
        }

        protected override void OnStart()
        {
            Login = new Login();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
