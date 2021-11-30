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


    public void TakeDamage()
    {
        animator.SetBool("Damage", true);
                StartCoroutine(ReturnToPosition());
    }

    public void Die()
    {
        animator.SetBool("Die", true);
        
    }

 IEnumerator ReturnToPosition()
    {
        yield return new WaitForSeconds(1f);
        animator.SetBool("Damage", false);

}
}


