using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttributes : MonoBehaviour
{
    public string name;
    public string type;
    public string description;
    public float health;
    public float healthReduce;
    public float power;
    public Animator animator;



    public void update()
    {
        if (health <= 0)
        {
            Die();
        }
    }

    public void TakeDamage()
    {
        animator.SetBool("Damage", true);
        //yield return new WaitForSeconds(2);
        animator.SetBool("Damage", false);
    }

    public void Die()
    {
        animator.SetBool("Die", true);
        
    }


}


