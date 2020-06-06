using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMovilProducto.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductoPage : ContentPage
    {
        public ProductoPage()
        {
            InitializeComponent();
            newButton.Clicked += NewButton_Clicked; //Que ocurre cuando se pulsa el boton
            find.Clicked += FindButton_Clicked;
            update.Clicked += UpdateButton_Clicked;
            delete.Clicked += DeleteButton_Clicked;
        }

        private void DeleteButton_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new BorrarProducto());//redirige a la pagina Borrar
        }

        private void UpdateButton_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new ActualizarProducto());//redirige a la pagina Actualizar
        }

        private void FindButton_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new ConsultarProducto());//redirige a la pagina Consultar
        }

        private void NewButton_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new CrearProductoPage()); //redirige a la pagina crear
        }
    }
}