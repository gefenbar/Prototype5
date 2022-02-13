using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    public Player()
    {
        this.attack = 3;
        this.defense = 4;
    }
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
    public string sword;
    public float bet;
    public float coins = 300;
    public int apple = 0;
    public int scroll = 0;
    public int potion = 0;
    public int wins = 0;
    public int losses = 0;
    public int bossNumber = 0;
    public Enemy[] enemies = new Enemy[4];
    public void resetEnemies()
    {
        for (int i = 0; i < 4; i++)
        {
            enemies[i].enemyBody.SetActive(true);
            if (i != bossNumber)
                enemies[i].enemyBody.SetActive(false);
        }
    }
}