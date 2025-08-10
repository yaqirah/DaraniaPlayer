using Newtonsoft.Json;
using System;
using static DaraniaPlayer.Common;

public class Track
{
    public TrackInfo trackInfo;

    public Track()
    {
        trackInfo = new TrackInfo();
    }

    public Track(string fileName)
	{
        trackInfo = new TrackInfo();
        trackInfo.fileName = fileName;
    }
    public Track(TrackInfo trackInfo)
    {
        this.trackInfo = trackInfo;
    }

    public void Save()
    {
        if (trackInfo == null)
        {
            System.Diagnostics.Debug.Print("TrackInfo is null!");
            return;
        }

        string json = JsonConvert.SerializeObject(this, Formatting.Indented);
        File.WriteAllText(@tracksFolder + trackInfo.jsonFileName, json);
    }
}
