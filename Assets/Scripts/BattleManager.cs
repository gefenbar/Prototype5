using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BattleManager : MonoBehaviour
{
    public Player player;
    Enemy enemy;
    Character enabled;
    Character disabled;
    public HealthBar playerHealthBar;
    public HealthBar enemyHealthBar;
    public Button apple;
    public Button potion;

    public Button scroll;

    HealthBar disabledHealthBar;

    public void Start()
    {
        enemy = player.GetEnemy();
        player.PickEnemy();
    }

    public void Update()
    {
        if (Player.apple < 1)
            apple.interactable = false;

        if (Player.potion < 1)
            potion.interactable = false;

        if (Player.scroll < 1)
            scroll.interactable = false;

    }

    public void ComputerMove()//example
    {
        enabled = enemy;
        disabled = player;
        disabledHealthBar = playerHealthBar;
            Debug.Log(enemy.name + " turn");

        if (enemy.health < 20)
        {
            //    Defense();
        }
        else
        {
            // Attack();
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
            disabled.health -= disabled.defense * enabled.attack;
            disabledHealthBar.SetHealth(disabled.health);
            if (disabled.health <= 0)
            {
                disabled.Die();
                if (disabled == player)
                {
                    Player.coins /= 2;
                    Player.losses += 1;
                }
                else
                {
                    Player.bossNumber++;
                    Player.coins *= 2;
                    Player.wins += 1;

                }
            }
        }

    }

    public void Defense()
    {
        enabled.Defense();
    }

    public void UseApple()
    {
        if (Player.apple > 0 && enabled == player)
        {
            Player.apple -= 1;
            player.UseApple();
        }

    }
    public void UsePotion()
    {
        if (Player.potion > 0 && enabled == player)
        {
            Player.potion -= 1;
            player.UsePotion();
        }
    }
    public void UseScroll()
    {
        if (Player.scroll > 0 && enabled == player)
        {
            Player.scroll -= 1;
            player.UseScroll();
        }
    }
}
