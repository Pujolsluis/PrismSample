using System;
using System.ComponentModel;
using Prism.Navigation;
using Prism.Services;

namespace PrismSample.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected IPageDialogService PageDialogService;
        public INavigationService NavigationService;

        public BaseViewModel(INavigationService navigationService, IPageDialogService pageDialogService = null)
        {
            NavigationService = navigationService;
            PageDialogService = pageDialogService;
        }

    }
}
