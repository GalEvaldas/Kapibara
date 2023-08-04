using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;
    [SerializeField] private AudioSource _musicSource, _effectsSourse;
    private void Awake()
    {
        if (Instance == null)

        { 
            Instance = this;
            DontDestroyOnLoad(gameObject);
        
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void PlaySound(AudioClip clip)
    {
        _effectsSourse.PlayOneShot(clip);
    }

    public void ToggleEffects()
    {
        _effectsSourse.mute = !_effectsSourse.mute;
    }

    public void ToggleMusic()
    {
        _musicSource.mute = !_musicSource.mute;
    }
}
