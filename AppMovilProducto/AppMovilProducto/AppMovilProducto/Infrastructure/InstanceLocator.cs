using System;
using System.Collections.Generic;
using System.Text;
using AppMovilProducto.ViewModels;
namespace AppMovilProducto.Infrastructure
{
    
    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            Main = new MainViewModel();
        }

    }
}
