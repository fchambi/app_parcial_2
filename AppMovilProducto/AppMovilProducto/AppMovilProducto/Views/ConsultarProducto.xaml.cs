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
            BtnSearch.Clicked += BtnSearch_Clicked; //Ocurre cuando busac solo uno
            BtnSearchTodos.Clicked += BtnSearchTodos_Clicked;//Busca todos
        }
        private void BtnSearchTodos_Clicked(object sender, EventArgs e)
        {
            Listar();
           
        }
        //Listar Muestra todos los productos
        public async void Listar()
        {
            HttpClient client = new HttpClient();//para la weapi
            var response = await client.GetStringAsync("https://fncproductodb20200605221301.azurewebsites.net/api/ConsultarVarios/{id}?");//En esta caso no introducimos parametro ya que buscamos todos
            var products = JsonConvert.DeserializeObject<List<Product>>(response);
            ProductsListView.ItemsSource = products;//Cargamos la lista con los productos de la consulta
        }
        //En caso de buscar un solo producto
        private  void BtnSearch_Clicked(object sender, EventArgs e)
        {

            string content = Convert.ToString(EntId.Text);//En este caso si enviamos de parametro el id del dato a buscar
            GetProducts(content);
            
        }
        public async void GetProducts(string id)
        {
            HttpClient client = new HttpClient(); 
            var response = await client.GetStringAsync("https://fncproductodb20200605221301.azurewebsites.net/api/ConsultarProducto/"+id);//Concatenamos la wepapi con el id del producto
            var products = JsonConvert.DeserializeObject<List<Product>>(response);
            ProductsListView.ItemsSource = products;
        }
    }
}