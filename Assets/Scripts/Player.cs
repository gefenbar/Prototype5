using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    /*singleton*/
    public static Player Instance { get; private set; }
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    /*singleton*/

    public static int coins = 300;
    public static string sword;
    public static int apple = 0;
    public static int scroll = 0;
    public static int potion = 0;
    public static int wins = 0;
    public static int losses = 0;
    public static float attack = 1;
    public static int defense = 1;
    public static int bossNumber = 0;
    public Enemy[] enemies = new Enemy[4];
    public Enemy GetEnemy()
    {
        for (int i = 0; i < 4; i++)
        {
            if (i != bossNumber)
                enemies[i].enemyBody.SetActive(false);
        }
        return enemies[bossNumber];
    }
    public void resetEnemies(){
           for (int i = 0; i < 4; i++)
        {
                enemies[i].enemyBody.SetActive(true);
        }
    }
}