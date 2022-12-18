using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TikTokBasicClone.Model;

namespace TikTokBasicClone.Data
{
    public  class DVideos
    {
        public static ObservableCollection<VideoModel> VideosList() 
        {
            return new ObservableCollection<VideoModel>() 
            { 
                new VideoModel()
                {
                    Video = "https://firebasestorage.googleapis.com/v0/b/tiktokclonedata.appspot.com/o/vedeo2_t.mp4?alt=media&token=90e5f9ae-e6d1-49c4-b8aa-9c176ead2b03"


                },
                new VideoModel()
                {
                    Video="https://firebasestorage.googleapis.com/v0/b/tiktokclonedata.appspot.com/o/vedeo3_t.mp4?alt=media&token=721ef49e-d999-4a0f-8800-a4da889da228"
                },
                  new VideoModel()
                {
                    Video="https://firebasestorage.googleapis.com/v0/b/tiktokclonedata.appspot.com/o/video4_t.mp4?alt=media&token=5cb25b0b-06c8-4ded-b03e-8299a5adb9ab"
                },
                    new VideoModel()
                {
                    Video="https://firebasestorage.googleapis.com/v0/b/tiktokclonedata.appspot.com/o/vieo1_t.mp4?alt=media&token=88f87226-5a57-43e3-a654-e3f4688bb2ca"
                }

            };
        }
    }
}
