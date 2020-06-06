using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppMovilProducto.Models;
using System.Net;

namespace AppMovilProducto.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CrearProductoPage : ContentPage
    {
        public CrearProductoPage()
        {
            InitializeComponent();
            BtnSave.Clicked += BtnSave_Clicked;    
        }

        private async void BtnSave_Clicked(object sender, EventArgs e)
        {
            Product products = new Product()
            {
                ProductId = Convert.ToString(EntId.Text),
                Precio = Convert.ToDouble(EntPrecio.Text),
                Cantidad = Convert.ToInt32(EntCantidad.Text),
                Nombre = Convert.ToString(EntNombre.Text)
            };
            var json = JsonConvert.SerializeObject(products);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpClient client = new HttpClient();
            var result = await client.PostAsync("https://fncproductodb20200605221301.azurewebsites.net/api/CrearProducto?", content);
            if (result.StatusCode == HttpStatusCode.Created)
            {
                await DisplayAlert("Hey", "Creaste el producto bien", "Todo bien");
            }
        }

        
    }
}