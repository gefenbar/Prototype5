using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    string name = "xxx";
    public bool isDefending;
    string type = "Warrior";
    public float health = 100;
    public int healthReduce = 2;
    public float power;
    public float defence;
    public string weakness;
    public string strength;
    bool hit = false;
    // string Wepons = "";
    public Animator animator;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        

    }


    IEnumerator Restart()
    {
        yield return new WaitForSeconds(1f);
    }
}
