using Newtonsoft.Json;
using System;
using static DaraniaPlayer.Common;

namespace DaraniaPlayer
{
    public static class Common
    {
        public static string tracksFolder = "tracks\\";

        public enum ENVIROMENT
        {
            NEUTRAL    = 0,
            COAST      = 1,
            DESERT     = 2,
            SWAMP      = 3,
            SNOW       = 4,
            GRASSLANDS = 5,
            FUTURISTIC = 6,
            INDUSTRIAL = 7
        }

        public enum VIBE
        {
            NEUTRAL       = 0,
            UPBEAT        = 1,
            MYSTERIOUS    = 2,
            TENSE         = 3,
            RELAXED       = 4,
            RELIGIOUS     = 5,
            FANCY         = 6,
            INVESTIGATION = 7,
            PARTY         = 8,
            SILLY         = 9,
            GRAND         = 10,
            MELANCHOLY    = 11,
            HOPEFUL       = 12
        }

        public enum SITUATION
        {
            TOWN    = 0,
            DUNGEON = 1,
            COMBAT  = 2,
            BOSS    = 3,
            TRAVEL  = 4
        }

        public class TrackInfo
        {
            public string     fileName      = "";
            public string     sourceName    = "";
            public string     trackName     = "";
            public double     volume        = 1.0; // Max = 1.0
            public ENVIROMENT enviroment    = 0;
            public VIBE       vibe          = 0;
            public SITUATION  situation     = 0;
            public string     jsonFileName  = "";
        }

        public enum PlayState
        {
            UNDEFINED     = 0,
            STOPPED       = 1,
            PAUSED        = 2,
            PLAYING       = 3,
            SCANFORWARD   = 4,
            SCANREVERSE   = 5,
            BUFFERING     = 6,
            WAITING       = 7,
            MEDIAENDED    = 8,
            TRANSITIONING = 9,
            READY         = 10,
            RECONNECTING  = 11,
            LAST          = 12
        }

        public enum LoopMode
        {
            NONE     = 0,
            SINGLE   = 1,
            PLAYLIST = 2,
            SHUFFLE  = 3
        }

        public static string Capitalize(string original)
        {
            return char.ToUpper(original[0]) + original.Substring(1).ToLower();
        }

        public static T IntToEnum<T>(int i) where T : System.Enum
        {
            return (T)Enum.Parse(typeof(T), i.ToString(), true);
        }

        public static async void StopPlayer(AxWMPLib.AxWindowsMediaPlayer player)
        {
            player.URL = null;
            await Task.Delay(1);

            try
            {
                while ((PlayState)player.playState is not (PlayState.STOPPED or PlayState.READY))
                {
                    await Task.Delay(1);
                }
            }
            catch (Exception e)
            {

            }
        }
    }
}