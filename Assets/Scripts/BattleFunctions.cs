using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleFunctions : MonoBehaviour
{
    public Animator animator;
    public EnemyAttributes enemy;
    public HealthBar playerHealthBar;
    public HealthBar enemyHealthBar;
    public Player player;
    Vector3 temp = new Vector3(1.0f, 0, 0);

    public void MoveRight()
    {
        animator.SetBool("moveright", true);
        player.transform.position -= temp;
        StartCoroutine(ResetButtons());
    }
    public void MoveLeft()
    {
        animator.SetBool("moveleft", true);
        player.transform.position += temp;
        StartCoroutine(ResetButtons());

    }
    public void Attack()
    {
        animator.SetBool("attack", true);
         if ((player.transform.position.x - enemy.transform.position.x < 1.5)&&(player.transform.position.x - enemy.transform.position.x > -1.5)){
            enemy.health -= enemy.healthReduce * player.power;
        enemyHealthBar.SetHealth(enemy.health);
         }
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
        player.isDefending = false;
        animator.SetBool("attack", false);
        animator.SetBool("Block", false);
        animator.SetBool("moveleft", false);
        animator.SetBool("moveright", false);
    }

}
