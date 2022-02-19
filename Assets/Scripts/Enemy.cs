 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : Character
{
    public int appleEnemy = 0;
    public int scrollEnemy = 0;
    public int potionEnemy = 0;
    public string toString()
    {
        return "Name: " + this.name + "\nAttack: " + this.attack + "\nDefense: " + this.defense;
    }
}