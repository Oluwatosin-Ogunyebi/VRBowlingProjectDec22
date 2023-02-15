using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    AudioSource playAudio;
    // Start is called before the first frame update
    void Start()
    {
        playAudio = GetComponent<AudioSource>();
    }

    public void PlayButton()
    {
        playAudio.Play();
    }
}
