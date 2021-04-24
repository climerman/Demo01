using Demo01.Network;
using Demo01.Services;
using Demo01.Utilities;
using Demo01.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo01
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();

            //Register Undo API Services
            DependencyService.Register<UndoService>();

            //Register dialog service
            DependencyService.Register<DialogService>();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
