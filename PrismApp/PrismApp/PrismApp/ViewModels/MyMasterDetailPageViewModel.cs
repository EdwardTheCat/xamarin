using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismApp.ViewModels
{
    

   
	public class MyMasterDetailPageViewModel : ViewModelBase   
	{
        private DelegateCommand<string> _navigateCommand;
        public DelegateCommand<string> NavigateCommand =>
            _navigateCommand ?? (_navigateCommand = new DelegateCommand<string>(NavigationCommandExecute, CanExecuteNavigationCommand));

        public MyMasterDetailPageViewModel(INavigationService navigationService) : base(navigationService)
        {
           
        }

    void NavigationCommandExecute(string uri)
    {
            NavigationService.NavigateAsync(uri);
    }

    bool CanExecuteNavigationCommand(string uri)
    {
        return true;
    }
}
}
