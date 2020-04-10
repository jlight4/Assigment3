using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    public AudioSource SFX;
    public AudioClip Bump;
    public AudioClip Select;
    public AudioClip Win;

    public static bool BumpSound;
    public static bool SelectSound;
    public static bool WinSound;

    void Start()
    {
        BumpSound = false;
        SelectSound = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (BumpSound)
        {
            SFX.PlayOneShot(Bump);
            BumpSound = false;
        }

        if (SelectSound)
        {
            SFX.PlayOneShot(Select);
            SelectSound = false;
        }

        if (WinSound)
        {
            SFX.PlayOneShot(Win);
            WinSound = false;
        }
    }
}
