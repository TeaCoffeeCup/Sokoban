using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayCrateSound : MonoBehaviour
{
    public AudioClip CrateMovement;
    public void CrateSound()
    {
        GetComponent<AudioSource>().PlayOneShot(CrateMovement);
    }
}