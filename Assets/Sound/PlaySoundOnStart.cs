using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnStart : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private AudioClip _clip;
    void Start()
    {
        SoundManager.Instance.PlaySound(_clip);
    }


}
