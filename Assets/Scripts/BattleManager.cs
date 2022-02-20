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
    public Text result;
    float distance;
    HealthBar disabledHealthBar;
    public GameObject playerBody;
    public Button[] buttons = new Button[10];
    public void Start()
    {
        Player.Instance.body.SetActive(true);
        Player.Instance.timer = player.timer;
        Player.Instance.soundManager = player.soundManager;
        Player.Instance.health = player.health;
        playerBody.transform.position = new Vector3(4, 0, 0);
        Player.Instance.body.transform.position = playerBody.transform.position;
        enemy = enemies[Player.Instance.bossNumber];
        playerBody.SetActive(false);
        for (int i = 0; i < enemies.Length; i++)
        {
            if (i != Player.Instance.bossNumber)
            {
                enemies[i].body.SetActive(false);
            }
            else
                enemies[i].body.SetActive(true);
        }
    }

    public void Update()
    {
        distance = Player.Instance.body.transform.position.x - enemy.transform.position.x;
        if (Player.Instance.apple < 1)
            apple.interactable = false;

        if (Player.Instance.potion < 1)
            potion.interactable = false;

        if (Player.Instance.scroll < 1)
            scroll.interactable = false;
    }

    public void ComputerMove()
    {
        DisableButtons();
        enabled = enemy;
        disabled = Player.Instance;
        disabledHealthBar = playerHealthBar;
        if (distance < 2.5 && & enemy.attack >= Player.Instance.attack)
        {
            Attack();
        }
        else if (distance < 2.5 && enemy.attack <= Player.Instance.attack && enemy.health > 50)
        {
            Defense();
        }
        else if (distance < 2.5 && Player.Instance.health < enemy.health && enemy.attack >= Player.Instance.attack)
        {
            Attack();
        }
        else if (distance < 2.5 && Player.Instance.apple > 0)
        {
            Defense();
        }
        else if (enemy.health < 20 && enemy.potionEnemy > 0 && distance > 2)
        {
            enemy.potionEnemy -= 1;
            enemy.UsePotion();
        }
        else if (enemy.health > 50 && enemy.appleEnemy > 0 && distance > 2)
        {
            enemy.appleEnemy -= 1;
            enemy.UseApple();
        }
        else if (enemy.attack < Player.Instance.attack - 5 && enemy.scrollEnemy > 0 && distance > 2)
        {
            enemy.scrollEnemy -= 1;
            enemy.UseScroll();
        }
        else if (1 < distance && distance < 3 && Player.Instance.scroll > 0)
        {
            MoveLeft();
            Attack();
        }
        else if (1 < distance && distance < 3 && Player.Instance.apple == 0)
        {
            MoveLeft();
            Defense();
        }
        else if (distance < 2.5)
        {
            Attack();
        }
        else if (distance < 2.5)
        {
            Defense();
        }
        else if (distance > 3)
        {
            MoveLeft();
        }
        else if (Player.Instance.counter < 5)
        {
            MoveRight();
        }
    }

    public void PlayerMove()
    {
        StartCoroutine(DelayButtons());
        enabled = Player.Instance;
        disabled = enemy;
        disabledHealthBar = enemyHealthBar;
    }
    IEnumerator DelayButtons()
    {
        yield return new WaitForSeconds(1f);
        EnableButtons();
    }



    public void MoveRight()
    {

        if (enabled.transform.position.x > -3 && enabled == enemy)
        {
            enabled.MoveRight();

        }
        if (distance > 1.25 && enabled == Player.Instance)
        {
            enabled.MoveRight();
        }



    }
    public void MoveLeft()
    {

        if (enabled.transform.position.x < 5 && enabled == Player.Instance)
        {
            enabled.MoveLeft();

        }
        if (distance > 1.25 && enabled == enemy)
        {
            enabled.MoveLeft();
        }


    }
    public void Attack()
    {
        enabled.Attack();

        if ((distance < 1.5) && (distance > -1.5) && !disabled.isDefending)
        {
            disabled.TakeDamage();
            disabled.health -= (enabled.attack / disabled.defense) + 3;
            disabledHealthBar.SetHealth(disabled.health);
            if (disabled.health <= 0)
            {
                disabled.Die();
                DisableButtons();
                if (disabled == Player.Instance)
                {
                    if (result.text == "YOU WIN!")
                    {
                        result.text = "IT'S A DRAW!";
                    }
                    else
                        result.text = "YOU LOSE!";
                    Player.Instance.coins -= Player.Instance.bet;
                    Player.Instance.losses += 1;
                }
                else
                {
                    if (Player.Instance.bossNumber == 15)
                    {
                        result.text = "YOU WIN THE GAME!";
                        Application.Quit();
                    }

                    else
                    {
                        result.text = "YOU WIN!";
                        Player.Instance.bossNumber++;
                        Player.Instance.coins += Player.Instance.bet;
                        Player.Instance.wins += 1;
                    }
                }
                StartCoroutine(BackToMain());
            }

            IEnumerator BackToMain()
            {
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
    void DisableButtons()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }
    }
    void EnableButtons()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = true;
        }
    }

    public void LeaveBattle()
    {
        Player.Instance.coins -= Player.Instance.bet / 2;
    }
}
