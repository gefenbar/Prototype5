using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



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
    public Enemy[] enemies = new Enemy[15];
    HealthBar disabledHealthBar;
    public GameObject playerBody;
    public Button[] buttons = new Button[6];
    public void Start()
    {
        Player.Instance.timer = player.timer;
        Player.Instance.soundManager = player.soundManager;
        Player.Instance.health = player.health;
        playerBody.transform.position= new Vector3(4, 0, 0);
        Player.Instance.body.transform.position=playerBody.transform.position;
              //  Player.Instance.body.position = playerBody.position;

        //Player.Instance.transform.position.x=player.transform.position.x;
        enemy = enemies[Player.Instance.bossNumber];
        playerBody.SetActive(false);
    }

    public void Update()
    {
        if (Player.Instance.apple < 1)
            apple.interactable = false;

        if (Player.Instance.potion < 1)
            potion.interactable = false;

        if (Player.Instance.scroll < 1)
            scroll.interactable = false;

    }

    public void ComputerMove()//example
    {
        enabled = enemy;
        disabled = Player.Instance;
        disabledHealthBar = playerHealthBar;
        // Debug.Log(enemy.name + " turn");

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
        enabled = Player.Instance;
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
                EndBattle();
                if (disabled == Player.Instance)
                {
                    Player.Instance.coins -= Player.Instance.bet;
                    Player.Instance.losses += 1;
                }
                else
                {
                    if (Player.Instance.bossNumber == 15)
                        Debug.Log("YOU WON!");

                    else
                    {
                        Player.Instance.bossNumber++;
                        Player.Instance.coins += Player.Instance.bet;
                        Player.Instance.wins += 1;
                    }
                }
                StartCoroutine(BackToMain());
            }

            IEnumerator BackToMain()
            {
                //Debug.Log("YOU WON THE FIGHT");
                yield return new WaitForSeconds(3f);
                SceneManager.LoadScene("Main");
            }

        }

    }

    public void Defense()
    {
        enabled.Defense();
    }

    public void UseApple()
    {
        if (Player.Instance.apple > 0 && enabled == Player.Instance)
        {
            Player.Instance.apple -= 1;
            Player.Instance.UseApple();
        }

    }
    public void UsePotion()
    {
        if (Player.Instance.potion > 0 && enabled == Player.Instance)
        {
            Player.Instance.potion -= 1;
            Player.Instance.UsePotion();
        }
    }
    public void UseScroll()
    {
        if (Player.Instance.scroll > 0 && enabled == Player.Instance)
        {
            Player.Instance.scroll -= 1;
            Player.Instance.UseScroll();
        }
    }
    public void EndBattle()
    {
for (int i = 0; i < buttons.Length; i++)
{
    buttons[i].interactable=false;
}
    }
}
