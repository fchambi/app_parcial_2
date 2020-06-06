using System;
using System.Collections.Generic;
using System.Text;
using AppMovilProducto.Models;

namespace AppMovilProducto.ViewModels
{
    public class MainViewModel
    {

        #region ViewModels
        private ProductoViewModel Producto;
        #endregion

        #region Constructor
        public MainViewModel()
        {
            instance = this;
            this.Producto = new ProductoViewModel();
        }
        #endregion

        #region Singleton
        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }
            return instance;
        }
        #endregion
    }
}
