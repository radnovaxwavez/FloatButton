using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FloatButton
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Device.SetFlags(new[] { "Expander_Experimental" }); //Note how the expander is called in the App class itself, not even the MainPage where you'd think it'd be referenced
            MainPage = new MainPage();
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
