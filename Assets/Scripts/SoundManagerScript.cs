using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip Attack, Block, Die, Heal, injured;
    static AudioSource audioSrc;




    // Start is called before the first frame update
    void Start()
    {
        Attack = Resources.Load<AudioClip>("Attack");
        /* 
               injured = Resources.Load<AudioClip>("injured");
               Heal = Resources.Load<AudioClip>("Heal");
               Die= Resources.Load<AudioClip>("Die");
               Block = Resources.Load<AudioClip>("Block");
        */
        audioSrc = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "Attack":
                audioSrc.PlayOneShot(Attack);
                break;
            /*            case "Block":
                            audioSrc.PlayOneShot(Block);
                            break;
                        case "Die":
                            audioSrc.PlayOneShot(Die);
                            break;
                        case "Heal":
                            audioSrc.PlayOneShot(Heal);
                            break;
                        case "injured":
                            audioSrc.PlayOneShot(injured);
                            break;
            */
            default:
                break;
        }
    }
}
