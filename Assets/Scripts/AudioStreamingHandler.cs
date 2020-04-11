using UnityEngine;
using UnityEngine.Networking;
using System.Collections;


public class AudioStreamingHandler : MonoBehaviour
{
 public AudioSource audioSource;   
    void Start()
    {
        StartCoroutine(GetAudioClip());
    }

    public IEnumerator GetAudioClip()
    {
        using (UnityWebRequest www = UnityWebRequestMultimedia.GetAudioClip("https://ia803005.us.archive.org/11/items/soundcloud-557089965/No_Copyright_Music_Chill_Lofi_Hip_Hop_Instrumental_Copyright_Free_Music_-_Days_Like_These-557089965.ogg", AudioType.OGGVORBIS))
        {
            www.SendWebRequest();
            while(!www.isDone)
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
            }
        }
    }
}