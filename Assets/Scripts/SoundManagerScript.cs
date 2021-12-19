using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public AudioClip Attack, Block, Die, Heal, Injured, Move;
    public AudioSource audioSrc;




    // Start is called before the first frame update
    void Start()
    {
        AudioSource audioSrc = GetComponent<AudioSource>();


    }




    public void AttackSound()
    {
        audioSrc.PlayOneShot(Attack);
    }
    public void BlockSound()
    {
        audioSrc.PlayOneShot(Block);
    }
    public void DieSound()
    {
        audioSrc.PlayOneShot(Die);
    }
    public void HealSound()
    {
        audioSrc.PlayOneShot(Heal);
    }
    public void InjuredSound()
    {
        audioSrc.PlayOneShot(Injured);

    }
    public void MoveSound()
    {
        audioSrc.PlayOneShot(Move);
    }


}
