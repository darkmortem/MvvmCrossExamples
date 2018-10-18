using System;
using System.Threading.Tasks;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace MasterDetailMvvmCross.ViewModels
{
    public class RootViewModel : BaseViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public RootViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override void ViewAppearing()
        {
            base.ViewAppearing();
          //  MvxNotifyTask.Create( async () => await this.InitializeViewModel());
        }

     /*   private async Task InitializeViewModel()
        {
            await _navigationService.Navigate<MenuViewModel>();
            await _navigationService.Navigate<FirstViewModel>();
        }*/

        public IMvxCommand ShowMenuCommand
        {
            get
            {
                return new MvxCommand(ShowMenuCommandExecuted);
            }
        }

        public IMvxCommand ShowFirstViewCommand
        {
            get
            {
                return new MvxCommand(ShowFirstViewCommandExecuted);
            }
        }

        private void ShowMenuCommandExecuted()
        {
            _navigationService.Navigate<MenuViewModel>();
        }

        private void ShowFirstViewCommandExecuted()
        {
            _navigationService.Navigate<FirstViewModel>();
        }



    }
}
