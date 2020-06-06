using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppMovilProducto.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net;

namespace AppMovilProducto.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActualizarProducto : ContentPage
    {
        public ActualizarProducto()
        {
            InitializeComponent();
            BtnUpdate.Clicked += BtnUpdate_Clicked;
            BtnUpdate2.Clicked += BtnUpdate2_Clicked;
        }

        private async void BtnUpdate2_Clicked(object sender, EventArgs e)
        {
            Product products = new Product()
            {
                ProductId = Convert.ToString(EntId.Text),
                Cantidad = Convert.ToInt32(EntCantidad.Text),
            };
            var json = JsonConvert.SerializeObject(products);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpClient client = new HttpClient();
            var result = await client.PutAsync(string.Concat("https://fncproductodb20200605221301.azurewebsites.net/api/SacarProducto/", EntId.Text), content);
            if (result.StatusCode == HttpStatusCode.Created)
            {
                await DisplayAlert("Hey", "Actuliazaste la cantidad del producto bien", "Todo bien");
            }
        }

        private async void BtnUpdate_Clicked(object sender, EventArgs e)
        {
            Product products = new Product()
            {
                ProductId = Convert.ToString(EntId.Text),
                Cantidad = Convert.ToInt32(EntCantidad.Text),
            };
            var json = JsonConvert.SerializeObject(products);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpClient client = new HttpClient();
            var result = await client.PutAsync(string.Concat("https://fncproductodb20200605221301.azurewebsites.net/api/IngresarProducto/", EntId.Text), content);
            if (result.StatusCode == HttpStatusCode.Created)
            {
                await DisplayAlert("Hey", "Actuliazaste la cantidad del producto bien", "Todo bien");
            }
        }
    }
}