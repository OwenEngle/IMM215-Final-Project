using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayPauseControl : MonoBehaviour
{
    public AudioSource radio;
    public float muteVolume;
    public bool muted;
    public bool muteUpdate;

    // Start is called before the first frame update
    void Start()
    {
        muteVolume = radio.volume;
        muted = false;
        muteUpdate = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (muteUpdate == true)
        {
            if (muted == true)
            {
                muteVolume = radio.volume;
                radio.volume = 0;
                muteUpdate = false;
            }
            else if (muted == false)
            {
                radio.volume = muteVolume;
                muteUpdate = false;
            }
            else
            {
                return;
            }
        }
        else
        {
            return;
        }



        if (Input.GetButtonDown("XRI_Left_SecondaryButton") || Input.GetButtonDown("XRI_Right_SecondaryButton")) /*b or y*/
        {
            muteUpdate = true;
            muted = false;
            

        }
        if (Input.GetButtonDown("XRI_Left_PrimaryButton") || Input.GetButtonDown("XRI_Right_PrimaryButton")) /*a or x*/
        {
            muteUpdate = true;
            muted = true;
            
            
        }
    }
}
