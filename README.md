# Description
An audio player that can sort tracks based on the selected environment, vibe, and situation. Users can import tracks from local files or URLs.

# Building
First install Visual Studio with Windows Forms. 
 1. Install project dependencies. Ensure that relevant dlls/exe are in the same folder as the build (DaraniaPlayer\bin\Debug\net8.0-windows).
	 - **Windows Media Player:** 
		 - Used as the base player.
		 - https://learn.microsoft.com/en-us/previous-versions/windows/desktop/wmp/using-the-windows-media-player-control-with-microsoft-visual-studio
	 - **yt-dlp:**
		 - Used to import audio from URLs.
		 - https://github.com/yt-dlp/yt-dlp
	 - **ffmpeg:**
		 - Used to by yt-dlp convert audio. Download the essentials build.
		 - https://ffmpeg.org/
 2. Build in Visual Studio.
	- TODO: Look up if anything needs to be configured to set up the dependencies.
