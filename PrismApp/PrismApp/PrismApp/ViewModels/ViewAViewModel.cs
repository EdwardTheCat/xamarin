using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace PrismApp.ViewModels
{
	public class ViewAViewModel : ViewModelBase
	{
        private DelegateCommand _navigateCommand;
        public DelegateCommand NavigateCommand =>
            _navigateCommand ?? (_navigateCommand = new DelegateCommand(NavigateCommandExecute, CanNavigateCommand));

        private bool CanNavigateCommand()
        {
            return true;
        }

        private void NavigateCommandExecute()
        {
            NavigationService.NavigateAsync("ViewB");
        }

        public ViewAViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "ViewA";
        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {
            base.OnNavigatedFrom(parameters);
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
        }

        override
       public void OnNavigatingTo(INavigationParameters parameters)
        {
            
        }
    }
}
