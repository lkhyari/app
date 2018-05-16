﻿using Prism;
using Prism.Ioc;
using Prism.Unity;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ArthsAppProject.Views;
using ArthsAppProject.ViewModels;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ArthsAppProject
{
    public partial class App : PrismApplication
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync("Hello");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<Hello, HelloViewModel>();
            containerRegistry.RegisterForNavigation<Login, LoginViewModel>();
            containerRegistry.RegisterForNavigation<NewUser, NewUserViewModel>();
            containerRegistry.RegisterForNavigation<MasterDetail, MasterDetailViewModel>();
            containerRegistry.RegisterForNavigation<Home, HomeViewModel>();
            containerRegistry.RegisterForNavigation<Exercises, ExercisesViewModel>();
            containerRegistry.RegisterForNavigation<MyPain, MyPainViewModel>();
            containerRegistry.RegisterForNavigation<MyAppointments, MyAppointmentsViewModel>();
            containerRegistry.RegisterForNavigation<Report, ReportViewModel>();
            containerRegistry.RegisterForNavigation<Questions, QuestionsViewModel>();
            containerRegistry.RegisterForNavigation<PainEvolution, PainEvolutionViewModel>();
            containerRegistry.RegisterForNavigation<PainEvaluation, PainEvaluationViewModel>();
            containerRegistry.RegisterForNavigation<SimpleExForm, SimpleExFormViewModel>();
            containerRegistry.RegisterForNavigation<PainExForm, PainExFormViewModel>();
            containerRegistry.RegisterForNavigation<ConsultEx, ConsultExViewModel>();
            containerRegistry.RegisterForNavigation<AddAppointment, AddAppointmentViewModel>();
            containerRegistry.RegisterForNavigation<DoctorList, DoctorListViewModel>();
            containerRegistry.RegisterForNavigation<UpdateAppointment, UpdateAppointmentViewModel>();
            containerRegistry.RegisterForNavigation<AddDoctor, AddDoctorViewModel>();
            containerRegistry.RegisterForNavigation<UpdateDoctor, UpdateDoctorViewModel>();
        }
    }
}
