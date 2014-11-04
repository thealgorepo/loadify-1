Loadify
=======

The Problem
-
Spotify offers a special mode, the offline mode. Using this offline mode, you are able to download tracks by storing it locally on your device for listening to music even if you don't have a connection to the internet.

Well, why would you develop a software to download tracks if you could simply do that by using the official client? In fact, you just could use the official client and use that offline mode mentioned before but it comes with a huge disadvantage: The only way to listen to downloaded tracks is to use the official Spotify client. Since Spotify encrypts their audio data, you won't be able to listen to the music you've downloaded once your Spotify premium membership expires.


The Solution
-
There isn't much to say about Loadify. It is (yet another) Spotify downloader that is open source - useable for everyone. We have provided some features that we personally found important when it comes to downloading music. But, how does it work?

Since audio files supplied by the client are encrypted, we needed to jump in a little bit earlier and thus used **libspotify**, the official Spotify library written in C (we actually use a C# wrapper that manages the transition from unmanaged to managed by marshalling). Since audio data is streamed into some type of callback once we told the API to load a certain track into the audio player, we just need to capture the data flying into this callback. The track is currently saved as `wave` file into the specified folder and then immediately gets converted to a `MP3` file.

Features
-

### User friendly, simple, beautiful
While this is not important for many other developers that did take hand on designing Spotify downloaders, it was very important for us to make using the software self-explainable and to keep things simple.

***

### Login and Authentication
The login is as simple as it gets. You just enter your username and password you'd normally use for logging into Spotify and click on `Login`. Please note that the _Remember me_ option works fine but requires to store your password unencrypted into the configuration file. If you can't deal with that, please don't use this feature.

![](http://i.epvpimg.com/JYQCg.png)

***

### Dashboard
After logging in, a new window containing your dashboard will open up. The software will start to fetch your playlists and display them in the left pane. 

The right pane is mainly used for configuration and settings. You may (currently) specify:
* where to store downloaded tracks
* where to store cache files for speeding up the login/playlist fetching process

Once you've selected some tracks (or whole playlists) for downloading, the `Download` button will be enabled that triggers the download contract.

![](http://i.epvpimg.com/LYhwg.png)

***

### Resizable Panes
Playlist or track names are too long to be fully displayed? That isn't a problem anymore if you know that you can easily use the slider to rule the sizes of both panes.

As you have might already found out, just grab the green bar with the dots on it and drag it to the left or right, depending on which panel you expect to be larger.

![](http://i.epvpimg.com/39FGe.png)

***

### Tracks and Playlists
Once you expand a playlist in the left pane, all associated tracks will be listed in the following format:

`<Artists> - Track name`

Additionally if you hover over the tracks, a tooltip will display the track duration.

![](http://i.epvpimg.com/Tdweh.png)

Each time you select a track, the software calculates an approximate time span that is needed for downloading all of the selected tracks. The estimated time is displayed below the playlist/track listings.

You might have also noted the red crosses before each track listing. This is an indicator that signals if the track already exists on the local file system in the specified download directory. If a red cross is shown, the track does not exist. If a green tick is shown, the track exists in the download directory.

Once you have started the download contract, the download status bar in the lower left corner will become visible informing you about the current download status: 

* The progress bar represents the status of the track being download.
* The drawing right from the progress bar contains the name of the track being downloaded
* (n/x) right from the drawing represents the status of the download contract. **n** being the current track index and **x** being the amount of tracks that the software was contracted with.

![](http://i.epvpimg.com/7xRkd.png)

***

### Searching for tracks
Sometimes you don't want to browse your playlists for a certain track you want to download. For quickly searching and finding tracks in your playlists, the search field was implemented:

Typing in __eminem__ for example, will display all tracks that got the word __eminem__ in their name somehow. (case insensitive)

Pressing enter will apply the search filter, removing the search text and pressing enter again will restore all playlists without the search filter.

![](http://i.epvpimg.com/cxSdf.png)

***

### Adding additional playlists and tracks
If you want to download playlists/tracks that you've not added to your spotify account, you can temporary add them in Loadify to select them for the download contract.

#### Playlists
Right click in an empty area of the panel where the playlists and tracks are shown and select __Add Playlist from Link__

![](http://i.epvpimg.com/WHjrc.png)

A dialog will be displayed prompting you to enter the link to the playlist you want to add. There are 2 types of playlist links:
* HTTP links (example: __http://open.spotify.com/user/spotify_germany/playlist/0QUQf1xMMbtArIbDjwi2Hf__)
* Spotify links (example: __spotify:user:spotify_germany:playlist:0QUQf1xMMbtArIbDjwi2Hf__)

Note the `/playlist/` and `:playlist:` section of the url.
If the url provided is a valid url to a playlist, Loadify will fetch all of it's tracks and add the new playlist in the left panel. Once you refresh your playlists, it will be removed if it is not your playlist)

![](http://i.epvpimg.com/hECMb.png)

#### Tracks
For adding single tracks into an existing playlist, you need to right click one of the playlists and select __Add Track from Link__. 

![](http://i.epvpimg.com/3TWTd.png)

This is basically following the same procedure as the __Add Playlist from Link__ feature explained earlier. The only difference lies in the urls.

While playlist urls contain a `/playlist/` and `:playlist:` section, tracks do not. This section is replaced with the string `/track/` or `:track:`.

![](http://i.epvpimg.com/0kouc.png)

