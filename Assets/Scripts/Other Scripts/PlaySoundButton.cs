using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundButton : MonoBehaviour
{
    private AudioManagerScript audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindWithTag("Audio").GetComponent<AudioManagerScript>();
    }

    public void PlaySound()
    {
        audioManager.PlaySFX(audioManager.buttonPanel);
    }
}
