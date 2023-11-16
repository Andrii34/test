using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    [SerializeField] private AudioSource ass;
  

    
    public void Play()
    {
        ass.Play();
    }
}
