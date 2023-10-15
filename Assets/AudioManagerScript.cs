using UnityEngine;
using UnityEngine.Audio;

public class AudioManagerScript : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    public AudioClip fly;
    public AudioClip gameOver;
    public AudioClip pickUpcoins;
    public AudioClip buttonPanel;

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }

    public void PlaySoundButton()
    {
        SFXSource.PlayOneShot(buttonPanel);
    }
}
