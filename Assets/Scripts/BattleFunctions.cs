using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleFunctions : MonoBehaviour
{
    public Animator animator;
    public EnemyAttributes enemy;
    
  //  public PlayerHealthBar playerBar ;
       // public EnemyHealthBar enemyBar;

        public Player player;
    //bool isDefending = false;
    public void MoveRight()
    {
        player.isDefending = false;
        animator.SetBool("moveright", true);
        Vector3 temp = new Vector3(1.0f, 0, 0);
        player.transform.position -= temp;
        StartCoroutine(ResetButtons());
    }
    public void MoveLeft()
    {
        player.isDefending = false;
        animator.SetBool("moveleft", true);
        Vector3 temp = new Vector3(1.0f, 0, 0);
        player.transform.position += temp;
        StartCoroutine(ResetButtons());

    }
    public void Attack()
    {
        player.isDefending = false;
        enemy.health -= enemy.healthReduce * player.power;
        animator.SetBool("attack", true);
        StartCoroutine(ResetButtons());
        

    }

    public void Defense()
    {
        player.isDefending = true;
        animator.SetBool("Block", true);
        StartCoroutine(ResetButtons());
    }

    IEnumerator ResetButtons()
    {
        yield return new WaitForSeconds(1f);
        animator.SetBool("attack", false);
        animator.SetBool("Block", false);
        animator.SetBool("moveleft", false);
        animator.SetBool("moveright", false);
    }
}
