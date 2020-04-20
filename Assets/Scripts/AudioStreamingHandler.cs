using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class AudioStreamingHandler : MonoBehaviour
{
    public AudioSource audioSource;
    public int songIndex;
    public string[] songUrls;
    bool playing = true;
    //public string Song1 = "https://ia803005.us.archive.org/11/items/soundcloud-557089965/No_Copyright_Music_Chill_Lofi_Hip_Hop_Instrumental_Copyright_Free_Music_-_Days_Like_These-557089965.ogg";
    void Start()
    {
        songIndex = 0;
        StartCoroutine(GetAudioClip());
    }

    public IEnumerator GetAudioClip()
    {
        while (playing)
        {
            string url = songUrls[songIndex];
            using (UnityWebRequest www = UnityWebRequestMultimedia.GetAudioClip(url, AudioType.OGGVORBIS))
            {
                www.SendWebRequest();
                while (!www.isDone)
                {
                    Debug.Log(www.downloadedBytes);
                    yield return null;
                }
                if (www.isNetworkError)
                {
                    Debug.Log(www.error);
                }
                else
                {
                    AudioClip streamedAudio = DownloadHandlerAudioClip.GetContent(www);
                    audioSource.clip = streamedAudio;
                    audioSource.Play();
                    yield return new WaitForSeconds(audioSource.clip.length);
                }

            }

            songIndex++;
            if (songIndex >= songUrls.Length)
            {
                songIndex = 0;
            }

        }
    }
    IEnumerator playList()
    {
        // for( int i = 0; i < songUrl.Length; i++)
        // {
        //     songUrl[0];
        //     Debug.Log("waiting");
        //     yield return new WaitForSeconds(2);
        //     songUrl[1];
        //     Debug.Log("waiting");
        //     yield return new WaitForSeconds(2)
        //     songUrl[2];
        //     Debug.Log("waiting");



        // // = "https://ia803005.us.archive.org/11/items/soundcloud-557089965/No_Copyright_Music_Chill_Lofi_Hip_Hop_Instrumental_Copyright_Free_Music_-_Days_Like_These-557089965.ogg";
        // yield return WaitForSeconds(240);

        // string Song2 
        // //= "https://ia803005.us.archive.org/11/items/soundcloud-557089965/No_Copyright_Music_Chill_Lofi_Hip_Hop_Instrumental_Copyright_Free_Music_-_Days_Like_These-557089965.ogg";
        // yield return WaitForSeconds(240);
        //dillinger markdown website
        //}
        yield return null;
    }
}