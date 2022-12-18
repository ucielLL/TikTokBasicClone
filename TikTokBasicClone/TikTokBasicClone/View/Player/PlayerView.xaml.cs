using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TikTokBasicClone.ViewModel;
using TikTokBasicClone.ViewModel.BaseVM;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TikTokBasicClone.View.Player
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlayerView : ContentPage
    {
        public PlayerView()
        {
            InitializeComponent();
            BindingContext = new PlayerViewModel();
            ((BaseViewModel)BindingContext).InitializeAsync(Navigation);
        }
    }
}