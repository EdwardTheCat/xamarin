using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace PrismApp.ViewModels
{
   
    public class MainPageViewModel : ViewModelBase
    {
        private DelegateCommand _navigateCommand;
        public DelegateCommand NavigateCommand =>
            _navigateCommand ?? (_navigateCommand = new DelegateCommand(NavigateCommandExecute, CanNavigateCommand));

        //public DelegateCommand SubmitCommand { get; private set; }
        //in constructor
        //SubmitCommand = new DelegateCommand(NavigateCommandExecute, CanNavigateCommand);
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            

            Title = "Main Page";
        }
        
        private void NavigateCommandExecute()
        {
            var p = new NavigationParameters();
            p.Add("id", 164);

            NavigationService.NavigateAsync("ViewA", p);
        }
        private bool CanNavigateCommand() { return true; }

    }
}
