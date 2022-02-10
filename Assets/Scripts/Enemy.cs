 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : Character
{public GameObject enemyBody;
    public string toString()
    {
        return "Name: " + this.name + "\nAttack: " + this.attack + "\nDefense: " + this.defense;
        // public string description = "Name: " + name + "\nAttack: " + this.attack + "\nDefense: " + this.defense;
    }
}