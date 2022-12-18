using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using TikTokBasicClone.Data;
using TikTokBasicClone.Model;
using TikTokBasicClone.ViewModel.BaseVM;

namespace TikTokBasicClone.ViewModel
{
    internal class PlayerViewModel : BaseViewModel
    {
        public PlayerViewModel()
        {
            ListVideos = DVideos.VideosList();
        }
        public void  ShowVideos()
        {
           
        }

        #region vars and properties 
        ObservableCollection<VideoModel> _ListVideos;

        public ObservableCollection<VideoModel> ListVideos
        {
            get { return _ListVideos; }
            set { SetProperty(ref _ListVideos, value); }
        } 
        #endregion
    }
}
