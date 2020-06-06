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

namespace AppMovilProducto.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConsultarProducto : ContentPage
    {
        public ConsultarProducto()
        {
            InitializeComponent();
            BtnSearch.Clicked += BtnSearch_Clicked;
            BtnSearchTodos.Clicked += BtnSearchTodos_Clicked;
        }

        private void BtnSearchTodos_Clicked(object sender, EventArgs e)
        {
            Listar();
           
        }
        public async void Listar()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync("https://fncproductodb20200605221301.azurewebsites.net/api/ConsultarVarios/{id}?");
            var products = JsonConvert.DeserializeObject<List<Product>>(response);
            ProductsListView.ItemsSource = products;
        }

        private  void BtnSearch_Clicked(object sender, EventArgs e)
        {

            string content = Convert.ToString(EntId.Text);
            GetProducts(content);
            
        }

        public async void GetProducts(string id)
        {
            HttpClient client = new HttpClient(); 
            var response = await client.GetStringAsync("https://fncproductodb20200605221301.azurewebsites.net/api/ConsultarProducto/"+id);
            var products = JsonConvert.DeserializeObject<List<Product>>(response);
            ProductsListView.ItemsSource = products;
        }
    }
}