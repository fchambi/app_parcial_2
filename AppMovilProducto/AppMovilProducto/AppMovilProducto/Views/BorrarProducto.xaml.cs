using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMovilProducto.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BorrarProducto : ContentPage
    {
        public BorrarProducto()
        {
            InitializeComponent();
            BtnDelete.Clicked += BtnDelete_Clicked;
        }

        private async void BtnDelete_Clicked(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            var result = await client.DeleteAsync(String.Concat("https://fncproductodb20200605221301.azurewebsites.net/api/Eliminar/", EntId.Text));
            if (result.IsSuccessStatusCode)
            {
                await DisplayAlert("Hey", "Borraste el producto", "Bien");
            }
            
        }
    }
}