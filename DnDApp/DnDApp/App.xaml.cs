using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using System.Diagnostics;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace DnDApp
{
    public partial class App : Application
    {
        public static string FilePath;

        //public App()
        //{
        //    InitializeComponent();
        //    MainPage = new NavigationPage(new MenuPage())
        //    {

        //    };
        //}
        public App(string filePath)
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MenuPage())
            {
                
            };

            FilePath = filePath;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
