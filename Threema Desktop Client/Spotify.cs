using SpotifyAPI.Local; //Base Namespace
using SpotifyAPI.Local.Enums; //Enums
using SpotifyAPI.Local.Models; //Models for the JSON-responses
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Threema_Desktop_Client
{
    class Spotify
    {
        private static SpotifyLocalAPI _spotify;
        private TDC _instance;
        //private StatusResponse _response;

        private void prepare()
        {
            _spotify = new SpotifyLocalAPI();

            if (!SpotifyLocalAPI.IsSpotifyRunning())
                SpotifyLocalAPI.RunSpotify();
            if (!SpotifyLocalAPI.IsSpotifyWebHelperRunning())
                SpotifyLocalAPI.RunSpotifyWebHelper();

            if (!_spotify.Connect())
                return;

            //_response = _spotify.GetStatus();
        }

        public Spotify(String uri, TDC tdc)
        {
            _instance = tdc;

            //var runningProcessByName = Process.GetProcessesByName("Spotify");
            /*if (runningProcessByName.Length == 0)
            {
                Process P = Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/Spotify/spotify.exe");
                while (!P.Responding)
                {
                    Console.WriteLine("spotify not responding!");
                }
            }*/
            
            String[] split = uri.Split('?');


            if (uri.StartsWith("https://"))
            {

                //TDC tdc = new TDC();
                //prepare();

                _spotify = new SpotifyLocalAPI();

                if (!SpotifyLocalAPI.IsSpotifyRunning())
                    SpotifyLocalAPI.RunSpotify();
                if (!SpotifyLocalAPI.IsSpotifyWebHelperRunning())
                    SpotifyLocalAPI.RunSpotifyWebHelper();

                if (!_spotify.Connect())
                    return;


                split[0] = "spotify:track:" + split[0].Substring(31, split[0].Length - 31);
                _spotify.PlayURL(split[0]);

                Thread.Sleep(100);

                _spotify = new SpotifyLocalAPI();

                if (!SpotifyLocalAPI.IsSpotifyRunning())
                    SpotifyLocalAPI.RunSpotify();
                if (!SpotifyLocalAPI.IsSpotifyWebHelperRunning())
                    SpotifyLocalAPI.RunSpotifyWebHelper();

                if (!_spotify.Connect())
                    return;

                StatusResponse _response = _spotify.GetStatus();

                Track track = _response.Track;
                Console.WriteLine(track.TrackResource.Name);

                _instance.Invoke(new Action(() =>
                {
                    _instance.trayIcon.Visible = true;
                    _instance.trayIcon.BalloonTipTitle = "Now playing on Spotify:";
                    _instance.trayIcon.BalloonTipIcon = ToolTipIcon.Info;
                    _instance.trayIcon.BalloonTipText = track.TrackResource.Name + " by " + track.ArtistResource.Name;
                    _instance.trayIcon.ShowBalloonTip(1000);
                }));

            }
            else if (uri.StartsWith("spotify:track:"))
                _spotify.PlayURL(uri);

        }
    }
}
