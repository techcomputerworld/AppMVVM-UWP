using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using AppMVVM.ViewModels;

namespace AppMVVM.Base
{
    public class ViewModelLocator
    {
        private IUnityContainer container;

        public ViewModelLocator()
        {
            container = new UnityContainer();

            container.RegisterType<MainViewModel>();
        }

        //vamos a hacer que sea el container el que resuelva las dependencias
        public MainViewModel MainViewModel => container.Resolve<MainViewModel>();

    }
}
