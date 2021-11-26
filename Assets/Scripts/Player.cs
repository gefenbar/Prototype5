using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    string Type = "Warrior";
    int Health = 100;
    public float PowerAttack;
    public float Defence;
    public string Weakness;
    public string Strength;
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

        if (Input.GetKeyDown("a") && !hit)
        {
            animator.SetBool("attack", true);
            hit = true;
            StartCoroutine(Restart());
        }

    }
    

    IEnumerator Restart()
    {
        yield return new WaitForSeconds(1f);
        hit = false;
        animator.SetBool("attack", false);
    }

void Attack()
    {

    }

}
