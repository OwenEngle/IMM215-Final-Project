using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeControl : MonoBehaviour
{
    public AudioSource radio;
    bool volumeChange;
    // Start is called before the first frame update
    void Start()
    {
        radio.volume = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {

        float rightControl = Input.GetAxis("XRI_Right_Primary2DAxis_Horizontal");

        float leftControl = Input.GetAxis("XRI_Left_Primary2DAxis_Horizontal");

        if ((rightControl == 0) && (leftControl == 0))
        {
            volumeChange = false;
        }
        if ((radio.volume < 1) & !volumeChange & (rightControl > 0) | (leftControl > 0))
        {
            radio.volume = radio.volume + 0.1f;
            volumeChange = true;
        }
        if ((radio.volume > 0) & !volumeChange & (rightControl < 0) | (leftControl < 0))
        {
            radio.volume = radio.volume - 0.1f;
            volumeChange = true;
        }
    }
}
