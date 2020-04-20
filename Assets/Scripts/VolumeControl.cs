using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeControl : MonoBehaviour
{
    public AudioSource radio;
    // Start is called before the first frame update
    void Start()
    {
        radio.volume = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("XRI_Right_primary2DAxis") || (Input.GetButtonDown("XRI_Left_primary2DAxis")) && (radio.volume < 1))
        {
            radio.volume = radio.volume + 0.1f;
        }
        if (Input.GetButtonDown("XRI_Right_secondary2DAxis") || (Input.GetButtonDown("XRI_Left_secondary2DAxis")) && (radio.volume > 0))
        {
            radio.volume = radio.volume - 0.1f;
        }
    }
}
