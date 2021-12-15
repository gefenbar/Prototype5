using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    public string name;
    public string type;
    public bool isDefending = false;
    public bool isAttacking = false;
    public float health;
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
