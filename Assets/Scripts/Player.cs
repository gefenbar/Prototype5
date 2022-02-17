using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
 //temp
    public void start()
    {
        for (int i = 0; i < 4; i++)
        {
            if (i == Player.Instance.sword)
            {
                physicalSword.GetComponent<MeshFilter>().sharedMesh = physicalSwords[i];
            }
        }
    }

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
                    DontDestroyOnLoad(Instance);

    }
    /*singleton*/
    public GameObject physicalSword;
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