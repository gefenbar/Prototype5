using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : Character
{
    public string toString()
    {
        return "Name: " + name + "\nAttack: " + this.attack + "\nDefense: " + this.defense;
        // public string description = "Name: " + name + "\nAttack: " + this.attack + "\nDefense: " + this.defense;
    }
}