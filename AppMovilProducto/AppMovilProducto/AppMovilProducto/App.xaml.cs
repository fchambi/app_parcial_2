using AppMovilProducto.ViewModels;
using AppMovilProducto.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMovilProducto
{
    public partial class App : Application
    {
        public static NavigationPage Navigator { get; set; } //Para navegar entre paginas de la app

        public App()
        {
            InitializeComponent();
           MainPage = new NavigationPage(new ProductoPage()); // se instancia en ProductPAge que es el menu principal
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
