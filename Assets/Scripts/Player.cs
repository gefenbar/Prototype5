using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    string name = "xxx";
    public bool isDefending;
    public bool canAttack ;
    string type = "Warrior";
    public float health = 100;
    public int healthReduce = 2;
    public float power;
    public float defence;
    public string weakness;
    public string strength;
    bool hit ;
    // string Wepons = "";
    public Animator animator;


    public void OnCollisionStay(Collision col)
    {
        if (col.gameObject.tag=="Enemy")
        {
            canAttack = true;
        }

    }
}
