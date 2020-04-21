using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrankensteinVolume : MonoBehaviour
{
    public AudioSource radio;
    bool volumeChange;
    public float muteVolume;
    public bool muted;
    public bool muteUpdate;
    // Start is called before the first frame update
    void Start()
    {
        radio.volume = 0.5f;
        muteVolume = radio.volume;
        muted = false;
        muteUpdate = false;
    }

    // Update is called once per frame
    void Update()
    {

        float rightControl = Input.GetAxis("XRI_Right_Primary2DAxis_Horizontal");

        float leftControl = Input.GetAxis("XRI_Left_Primary2DAxis_Horizontal");

        if ((rightControl == 0) & (leftControl == 0))
        {
            volumeChange = false;
        }
        if ((radio.volume < 1) & !volumeChange && (rightControl > 0) | (leftControl > 0))
        {
            if (muted == false)
            {
                radio.volume = radio.volume + 0.1f;
                volumeChange = true;
            }
            else
            {
                return;
            }
        }
        if ((radio.volume > 0) & !volumeChange && (rightControl < 0) | (leftControl < 0))
        {
            if (muted == false)
            {
                radio.volume = radio.volume - 0.1f;
                volumeChange = true;
            }
            else
            {
                return;
            }
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
    }
}
