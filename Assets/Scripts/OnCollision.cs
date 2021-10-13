using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision : MonoBehaviour
{
    public AudioSource _audiosource;

    private void Update()
    {
        ControlHealth.col += PlayAudio;
    }

    private void PlayAudio()
    {
        _audiosource.Play();
    }
}
