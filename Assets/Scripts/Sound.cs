using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public static AudioClip jumpSound, pickedStoneBlockSound;
    public static AudioSource src;

    // Start is called before the first frame update
    void Start()
    {
        jumpSound = Resources.Load<AudioClip>("jump");
        pickedStoneBlockSound = Resources.Load<AudioClip>("picked_StoneBlock");
       
        src = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public static void PlaySound(string SoundName)
    {
        switch (SoundName)
        {
            case "jump":
                src.PlayOneShot(jumpSound);
                break;
            case "picked_StoneBlock":
                src.PlayOneShot(pickedStoneBlockSound);
                break;
        }
    }
}
