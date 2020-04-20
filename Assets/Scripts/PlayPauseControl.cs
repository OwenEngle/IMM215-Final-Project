using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayPauseControl : MonoBehaviour
{
    public AudioSource radio;
    public float muteVolume;
    public bool muted;

    // Start is called before the first frame update
    void Start()
    {
        muteVolume = radio.volume;
        muted = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("XRI_Left_SecondaryButton") || Input.GetButtonDown("XRI_Right_SecondaryButton")) /*b or y*/
        { 
            if(muted == false)
            {
                muteVolume = radio.volume;
                radio.volume = 0;
            }
            else
            {
                return;
            }
           
        }
        if (Input.GetButtonDown("XRI_Left_PrimaryButton") || Input.GetButtonDown("XRI_Right_PrimaryButton")) /*a or x*/
        {   
            if(muted == true)
            {
                radio.volume = muteVolume;
            }
            else
            {
                return;
            }
            
        }
    }
}
