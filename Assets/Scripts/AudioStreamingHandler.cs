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
        using (UnityWebRequest www = UnityWebRequestMultimedia.GetAudioClip("http://www.teiubescrecords.com:8000/chill.ogg", AudioType.MPEG))
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