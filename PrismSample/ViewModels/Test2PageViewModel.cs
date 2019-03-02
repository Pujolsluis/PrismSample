using System;
using Prism.Navigation;
using Prism.Services;
using PrismSample.Models;

namespace PrismSample.ViewModels
{
    public class Test2PageViewModel : BaseViewModel, INavigationAware
    {
        public User User { get; set; }

        public Test2PageViewModel(INavigationService navigationService, IPageDialogService pageDialogService = null) : base(navigationService, pageDialogService)
        {
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            if(parameters.ContainsKey("UserInformation"))
            {
                User = (User)parameters["UserInformation"];
            }
        }

        public void OnNavigatingTo(INavigationParameters parameters)
        {
        }
    }
}
