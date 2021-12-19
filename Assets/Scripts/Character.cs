using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    int counter = 10;
    public Text timer;
    public string name;
    public string type;
    public bool isDefending = false;
    public bool isAttacking = false;
    public float health = 100;
    public int healthReduce;
    public float power;
    public string weakness;
    public string strength;
    public string description;
    public SoundManagerScript soundManager;
    public Animator animator;


    Vector3 temp = new Vector3(1.0f, 0, 0);

    public void MoveRight()
    {
        animator.SetBool("moveright", true);
        transform.position -= temp;
        StartCoroutine(ReturnToPosition());
        soundManager.MoveSound();
    }

    public void MoveLeft()
    {
        animator.SetBool("moveleft", true);
        transform.position += temp;
        StartCoroutine(ReturnToPosition());
        soundManager.MoveSound();

    }

    public void Attack()
    {

        animator.SetBool("attack", true);
        StartCoroutine(ReturnToPosition());
        soundManager.AttackSound();

    }


    public void Defense()
    {
        isDefending = true;
        animator.SetBool("Block", true);
        StartCoroutine(ReturnToPosition());
        soundManager.BlockSound();


    }

    public void TakeDamage()
    {
        animator.SetBool("Damage", true);
        StartCoroutine(ReturnToPosition());
        soundManager.InjuredSound();
    }

    public void Die()
    {
        animator.SetBool("die", true);
        StartCoroutine(ReturnToPosition());
        soundManager.DieSound();


    }

    public void UseApple()
    {
        animator.SetBool("useapple", true);
        power += 10;
        StartCoroutine(UpgradesTimer("Apple"));
        // StartCoroutine(ReturnToPosition());
    }
    public void UsePotion()
    {
        animator.SetBool("usepotion", true);
        health += 20;
        StartCoroutine(UpgradesTimer("Potion"));
        //StartCoroutine(ReturnToPosition());
    }
    public void UseScroll()
    {
        power += 8;
        health += 12;
        animator.SetBool("usescroll", true);
        StartCoroutine(UpgradesTimer("Scroll"));
        //StartCoroutine(ReturnToPosition());
    }

    IEnumerator ReturnToPosition()
    {
        yield return new WaitForSeconds(1f);
        //isDefending = false;
        animator.SetBool("Damage", false);
        animator.SetBool("attack", false);
        animator.SetBool("Block", false);
        animator.SetBool("moveleft", false);
        animator.SetBool("moveright", false);

    }
    IEnumerator UpgradesTimer(string upgrade)
    {
        timer.text = counter.ToString();

        if (counter == 0)
        {
            if (upgrade == "Apple")
            {
                power -= 10;

                animator.SetBool("useapple", false);
            }

            if (upgrade == "Potion")
            {
                health -= 20;

                animator.SetBool("usepotion", false);

            }
            if (upgrade == "Scroll")
            {
                power -= 8;
                health -= 12;
                animator.SetBool("usescroll", false);
            }
            counter = 10;
            timer.text = " ";
        }
        else
        {
            yield return new WaitForSeconds(1f);
            counter--;
            StartCoroutine(UpgradesTimer(upgrade));

        }

    }

}
