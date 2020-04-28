using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace radio_player_desktop.BAL
{
    public class Main
    {
        private DAL.Api _api;
        private MediaFoundationReader _mf;
        private WaveOutEvent _wo;


        public Main() {
            _api = new DAL.Api();
        }


        public async Task  Play() 
        {

            var url = "https://magic.radioca.st/stream";


            _mf = new MediaFoundationReader(url);
            _wo = new WaveOutEvent();


            _wo.Init(_mf);
            _wo.Play();

                await Task.Run(() => {
                    while (_wo.PlaybackState == PlaybackState.Playing)
                    {
                        Thread.Sleep(1000);
                    }
                });

            

        }

        public void Stop() {
            //_player.controls.stop();

            _wo.Stop();
            _wo.Dispose();
        }


    }
}
