using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch : MonoBehaviour
{
    public AudioSource Torchsound;
    public Light FL;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            FL.enabled = !FL.enabled;
            Torchsound.Play();
        }

        

    }
}
