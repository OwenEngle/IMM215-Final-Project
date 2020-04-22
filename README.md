# LO-FI VR ReadMe Document
IMM 215, Spring 2020

### Desciption 
The Lo-Fi VR experience is a relaxing get-away in arms reach. View the stars as you listen to chill hip-hop beats and relax. 

This project was designed for the Oculus Quest. It downloads chill/relaxing hip-hop songs from the internet and playes them in a virtual outdoor environment. This project is a protoype with three pre-selected chill-hop songs.

  

### VR Volume Controls
 To mute the song in VR Press A or X on the controller.
 To Ummute the song Press B or Y.
 You can increase the volume by flicking the trigger in the up direction.
 You can decrease the volume by flicking the trigger in the down direction.
 The radio is interactible! To grab the radio, point the laser-pointer at it and press the grab button on the controller.


## Audio Streaming Handler Script Implimentation
The Audio Streaming Handler script downloads an audio file of the type ogg and converts it into an audio clip which is visible in the inspector. Attach the Audio Streaming Handler script to a gameobject in the scence and add an audio source componet to it. On the streaming handler script, where it says 'Audio Source', drag the audio source that you just created into it,  it should look somthing like this.

![Screenshot (73)_LI.jpg](https://www.dropbox.com/s/9u741ir86k82yx2/Screenshot%20%2873%29_LI.jpg?dl=0&raw=1)

In the inspector increase the number in the 'Song Urls' space to 1 or more, then in the new space(s) paste the url of your chosen audio file(s) into them (use audio files of the type ogg). When play mode is activated, wait a few mommnets as the song is now being downloaded. Once downloading is complete, the song will automatically play.

(In the image above the game object with the audio source is called 'Radio').

## Volume Manager Script Implimentation

The Volume Manager script handles the volume control for VR input; implimentation is very simliar to the Streaming Handler script. Attach this script to the same game object that the Audio Streaming Handler is one. In the inspeactor under 'Volume manager' use the same audio source that was added to the Audio Streaming Handler and drag game object with that source it into the open Audio source space. Now the audio volume can be controlled through controller input (see VR volume Controls above). 

## Contributors
Dyaln Boswell (Volume Control: scripting mute and Play functions), Owen Engle (Volume control: scripting increasing and drecreasing volume functions, Song playlist script), Wayeera Robertson (Song playlist and streaming handler script), Professor Hunter Dyar of Chatham University (helped with everything, thank you!).

Made with Unity

## Credits
Imported Assets
- Geoff Dallimore, 'Real Stars Skybox Lite', Apr 16 2020. Retrieved from, https://assetstore.unity.com/packages/3d/environments/sci-fi/real-stars-skybox-lite-116333
Designer's website, http://dreamsofgerontius.com/ 
- Ink Phantom Studio, Free Stylized Nature Environment, Apr 20, 2020, Retrived from, 
https://assetstore.unity.com/packages/3d/environments/free-stylized-nature-environment-96371
Designer's website, https://inkphantomstudio.wordpress.com/
- Artkovski, Illistrated Nature (sample), Apr 10, 2020, Retrieved from,
https://assetstore.unity.com/packages/3d/vegetation/the-illustrated-nature-sample-161188
Designer's website, https://www.matkovskidragos.com/
- IL.ranch, Old Radio "Ocean", Apr 20, 2020, Retrieved from, 
https://assetstore.unity.com/packages/3d/props/interior/old-radio-ocean-72923
Designer's website, https://ilonion.com/

Music
- The Digitized Maker, Days Like These, Apr 20, 2020, Retrieved from,
https://archive.org/details/soundcloud-557089965
Source's website, https://soundcloud.com/captain_brine/no-copyright-music-chill-lofi-hip-hop-instrumental-copyright-free-music-days-like-these (Note: This track is no longer availible at this site)
- Bass radio, DJ Quads, At My Front Door, Apr 20, 2020, Retrieved from, 
https://archive.org/details/soundcloud-484939842
Source's website, https://soundcloud.com/user-615618473/dj-quads-at-my-front-door-chill-no-copyright-lofi-hip-hop-music
-No Copyright LOFI, L33, I need a Girl, Retrieved from, 
https://archive.org/details/soundcloud-615981939
Source's website, https://soundcloud.com/nocopyrightlofi/copyright-free-chill-lofi-hiphop-i-need-a-girl-by-l33


###### Chatham University University Immersive Media program. April 21, 2020. 
