using System;
using System.ComponentModel;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;

namespace PrismSample.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
       
        public bool EnableNavigation { get; set; }
        public DelegateCommand OnNextCommand { get; set; }

        public MainPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService = null) : base(navigationService, pageDialogService)
        {
            OnNextCommand = new DelegateCommand(async () =>
            {
                await NavigationService.NavigateAsync("Test1Page");
            }).ObservesCanExecute(() => EnableNavigation);
        }

    }
}
