using System;
using TikTokBasicClone.View.Player;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TikTokBasicClone
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PlayerView();
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
