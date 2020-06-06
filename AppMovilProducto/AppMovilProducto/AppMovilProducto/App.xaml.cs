using AppMovilProducto.ViewModels;
using AppMovilProducto.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMovilProducto
{
    public partial class App : Application
    {
        public static NavigationPage Navigator { get; set; }

        public App()
        {
            InitializeComponent();
           MainPage = new NavigationPage(new ProductoPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
