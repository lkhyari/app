using System;
using Prism;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using ArthsAppProject.Infrastructure;

namespace ArthsAppProject.ViewModels
{
    public class MyPainViewModel : AppMapViewModelBase
    {


        public MyPainViewModel(INavigationService navigationService) : base (navigationService)
        {
        }
    }
}
