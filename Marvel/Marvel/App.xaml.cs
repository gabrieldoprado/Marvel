using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Marvel.IoC;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Marvel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Resolver.RegistryDependency();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
