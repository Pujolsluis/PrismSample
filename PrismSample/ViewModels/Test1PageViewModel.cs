using System;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using PrismSample.Models;

namespace PrismSample.ViewModels
{
    public class Test1PageViewModel : BaseViewModel
    {
        public User User { get; set; } = new User();
        public DelegateCommand OnLoginCommand { get; set; }

        public Test1PageViewModel(INavigationService navigationService, IPageDialogService pageDialogService = null) : base(navigationService, pageDialogService)
        {
            OnLoginCommand = new DelegateCommand(async () => await LoginUser());
        }

        async Task LoginUser()
        {
            if(string.IsNullOrEmpty(User.Username) || string.IsNullOrEmpty(User.Password))
            {
                if (string.IsNullOrEmpty(User.Username) || string.IsNullOrEmpty(User.Password))
                    await PageDialogService.DisplayAlertAsync("Error", "You must complete all required fields, to continue", "Ok");
                return;
            }

            NavigationParameters navParams = new NavigationParameters();
            navParams.Add("UserInformation", User);
            await NavigationService.NavigateAsync("Test2Page", navParams);

            //await NavigationService.NavigateAsync(new Uri($"Test2Page?UserInformation={User}", UriKind.Relative));

        }

        private bool AllFieldsValid()
        {
            return !string.IsNullOrEmpty(User.Username) && !string.IsNullOrEmpty(User.Password);
        }
    }
}
