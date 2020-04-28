using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radio_player_desktop.BAL
{
    public class Main
    {
        private WMPLib.WindowsMediaPlayer _player = new WMPLib.WindowsMediaPlayer();
        private DAL.Api _api;


        public Main() {
            _player = new WMPLib.WindowsMediaPlayer();
            _api = new DAL.Api();
        }


        public void Play() {

            _player.URL = _api.Wish;
            _player.settings.volume = 100;

            _player.controls.play();

        }

        public void Stop() {
            _player.controls.stop();
        }


    }
}
