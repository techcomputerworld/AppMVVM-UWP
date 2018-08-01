using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
namespace AppMVVM.Base
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged ([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        /* 
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }*/
        /* el del tutorial pone que no es necesario que implemente la notificacion del cambio asi que a saber que hacer seguire el tutorial
         * despues veo si es o no necesario
        */
        private Frame _frame;
        public Frame Frame
        {
            get { return _frame; }
            set
            {
                _frame = value;
                RaisePropertyChanged();
            }
        }
        //cada vez que naveguemos a una pagina va a suplantar este metodo el args a esa pagina 
        public abstract Task OnNavigateTo(NavigationEventArgs args);
        public abstract Task OnNavigatedFrom(NavigationEventArgs args);

        internal void SetAppFrame(Frame viewFrame)
        {
            _frame = viewFrame;
        }
    }
}
