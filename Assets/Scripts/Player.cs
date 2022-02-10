using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    public static Player Instance { get; private set; }
    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
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
    public Enemy [] enemies = new Enemy[4];
    public Enemy GetEnemy (){
    return enemies[bossNumber];
    }
    public void PickEnemy(){
        for (int i = 0; i < 4; i++)
        {
            if(i!=bossNumber)
            enemies[i].enemyBody.SetActive(false);
        }
    }
}