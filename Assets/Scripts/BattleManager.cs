using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public Character enemy;
    public Character player;
    Character enabled;
    Character disabled;
    public HealthBar playerHealthBar;
    public HealthBar enemyHealthBar;

    HealthBar disabledHealthBar;

    public void ComputerMove()//example
    {
        enabled = enemy;
        disabled = player;
        disabledHealthBar = playerHealthBar;

        if (enemy.power > 3)
        {
            Defense();
        }
        else if (enemy.health < 20)
        {
        }
    }


    public void PlayerMove()
    {
        enabled = player;
        disabled = enemy;
        disabledHealthBar = enemyHealthBar;
    }

    public void MoveRight()
    {
        if (enabled.transform.position.x > (disabled.transform.position.x + 1.5))
        {
            enabled.MoveRight();
        }
        else
        {
            //pop up message to the screen
        }


    }
    public void MoveLeft()
    {

        if (enabled.transform.position.x < 5)
        {
            enabled.MoveLeft();

        }
        else
        {
            //pop up message to the screen
        }

    }
    public void Attack()
    {
        enabled.Attack();

        if ((enabled.transform.position.x - disabled.transform.position.x < 1.5) && (enabled.transform.position.x - disabled.transform.position.x > -1.5) && !disabled.isDefending)
        {
            disabled.TakeDamage();
            disabled.health -= disabled.healthReduce * enabled.power;
            disabledHealthBar.SetHealth(disabled.health);
            if (disabled.health <= 0)
            {
                disabled.Die();
            }
        }

    }

    public void Defense()
    {
        enabled.Defense();
    }



}

