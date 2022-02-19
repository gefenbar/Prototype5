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
                    DontDestroyOnLoad(Instance);

    }
    /*singleton*/

    public Mesh[] physicalSwords = new Mesh[4];
    public int sword;
    public float bet;
    public float coins = 500;
    public int apple = 0;
    public int scroll = 0;
    public int potion = 0;
    public int wins = 0;
    public int losses = 0;
    public int bossNumber = 0;
}

