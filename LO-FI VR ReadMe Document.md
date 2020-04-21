# LO-FI VR ReadMe Document
IMM 215, Spring 2020

### Desciption 
Lo-Fi VR is an experience designed for the Oculus Quest that downloads chill/relaxing hip-hop songs from the internet and playes them in a virtual outdoor environment. This protoype has a list of three songs and allows for mute, puase and play functions. 

### Controls
 To mute the song in VR Press A or X on the controller.
 To Ummute the song Press B or Y.
 You can increase the volume by flicking the trigger in the up direction.
 You can decrease the volume by flicking the trigger in the down direction.
 The radio is interactible! to grab the radio point the laser-pointer at it and press the grab button on the controller.


## Script Implimentation
the Audio Streaming Handler script downloads an audio file of the type ogg and converts it into an audio clip which is visible in the inspector. Attach the Streaming Handler script to a gameobject in the scence and add an audio source componet to it. On the streaming handler script, where it says 'Audio Source', drag the audio source that you just created into it, it should look somthing like this.
![Screenshot (73)_LI.jpg](https://www.dropbox.com/s/9u741ir86k82yx2/Screenshot%20%2873%29_LI.jpg?dl=0&raw=1)

In the inspector increase the number in the 'Song Urls' space to 1 or more, then in the new space(s) paste the url of your chosen audio file(s) into them (use audio files of the type ogg). When play mode is activated, wait a few mommnets as the song is now being downloaded. Once downloading is complete, the song will automatically play. Enjoy!

## Contributors
Dyaln Boswell, Owen Engle, Wayeera Robertson, Professor Hunter Dyar of Chatham University.

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







