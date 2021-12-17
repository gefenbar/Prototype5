using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public static int coins=300;
    public static string sword;
    public static int apple = 0;
    public static int scroll = 0;
    public static int potion = 0;
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

    public Animator animator;

    Vector3 temp = new Vector3(1.0f, 0, 0);

    public void MoveRight()
    {
        animator.SetBool("moveright", true);
        transform.position -= temp;
        StartCoroutine(ReturnToPosition());

    }

    public void MoveLeft()
    {
        animator.SetBool("moveleft", true);
        transform.position += temp;
        StartCoroutine(ReturnToPosition());

    }

    public void Attack()
    {

        animator.SetBool("attack", true);
        StartCoroutine(ReturnToPosition());
        SoundManagerScript.PlaySound("Attack");

    }


    public void Defense()
    {
        isDefending = true;
        animator.SetBool("Block", true);
        StartCoroutine(ReturnToPosition());
        //SoundManagerScript.PlaySound("Block");


    }

    public void TakeDamage()
    {
        animator.SetBool("Damage", true);
        StartCoroutine(ReturnToPosition());
        //SoundManagerScript.PlaySound("injured");
    }

    public void Die()
    {
        animator.SetBool("die", true);
        StartCoroutine(ReturnToPosition());
        //SoundManagerScript.PlaySound("Die");


    }

    public void UseApple()
    {
        animator.SetBool("useapple", true);
        StartCoroutine(ReturnToPosition());
    }
    public void UsePotion()
    {
        animator.SetBool("usepotion", true);
        StartCoroutine(ReturnToPosition());
    }
    public void UseScroll()
    {

        animator.SetBool("usescroll", true);
        StartCoroutine(ReturnToPosition());
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
}
