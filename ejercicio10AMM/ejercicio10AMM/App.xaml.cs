using ejercicio10AMM.Services;
using ejercicio10AMM.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ejercicio10AMM
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new ViewToViewDemo();
            //MainPage = new MainPage();
            //MainPage = new PickerDemo();
            //MainPage = new ListViewDemo();
            //MainPage = new BindingModeDemo();
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
