using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleFunctions : MonoBehaviour
{
    public EnemyAttributes enemy;
    
  //  public PlayerHealthBar playerBar ;
       // public EnemyHealthBar enemyBar;

        public Player player;
    //bool isDefending = false;
    public void MoveRight()
    {
        player.isDefending = false;


        Vector3 temp = new Vector3(1.0f, 0, 0);
        player.transform.position -= temp;
    }
    public void MoveLeft()
    {
        player.isDefending = false;

        Vector3 temp = new Vector3(1.0f, 0, 0);
        player.transform.position += temp;

    }
    public void Attack()
    {
        player.isDefending = false;
        enemy.health -= enemy.healthReduce * player.power;
        

    }

    public void Defense()
    {
        player.isDefending = true;
    }
}
