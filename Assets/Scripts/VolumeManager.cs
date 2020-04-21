using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeManager : MonoBehaviour
{
    public AudioSource radio;
    bool volumeChange;
    public bool muted;
    void Start()
    {
        radio.volume = 0.5f;
    }
    void Update()
    {
        float rightControl = Input.GetAxis("XRI_Right_Primary2DAxis_Vertical");
        float leftControl = Input.GetAxis("XRI_Left_Primary2DAxis_Vertical");
        if ((rightControl == 0) & (leftControl == 0))
        {
            volumeChange = false;
        }
        if ((radio.volume < 1) & !volumeChange && (rightControl < 0) | (leftControl < 0))
        {
            if (muted == false)
            {
                radio.volume = radio.volume + 0.1f;
                volumeChange = true;
            }
        }
        if ((radio.volume > 0) & !volumeChange && (rightControl > 0) | (leftControl > 0))
        {
            if (muted == false)
            {
                radio.volume = radio.volume - 0.1f;
                volumeChange = true;
            }
        }
        if (Input.GetButtonDown("XRI_Left_SecondaryButton") || Input.GetButtonDown("XRI_Right_SecondaryButton")) /*b or y*/
        {
            muted = false;
            radio.mute = false;
        }
        if (Input.GetButtonDown("XRI_Left_PrimaryButton") || Input.GetButtonDown("XRI_Right_PrimaryButton")) /*a or x*/
        {
            muted = true;
            radio.mute = true;
        }
    }
}
