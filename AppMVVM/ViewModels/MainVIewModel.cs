using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppMVVM.Base;
using Windows.UI.Xaml.Navigation;

namespace AppMVVM.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private string holaMundo;
        public string HolaMundo
        {
            get { return holaMundo; }
            set
            {
                holaMundo = value;
                RaisePropertyChanged();
            }
        }
        public override Task OnNavigateTo(NavigationEventArgs args)
        {
            HolaMundo = "Hola mundo ¡¡desde el ViewModel!!";
            return null;
        }
        public override Task OnNavigatedFrom(NavigationEventArgs args)
        {
            
            return null;
        }

       
    }
}
