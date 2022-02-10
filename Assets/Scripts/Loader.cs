using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Loader : MonoBehaviour
{ 
    public Text description;
    void Start(){     
        //description.text=Player.Instance.GetEnemy().toString();
        StartCoroutine(StartBattle());
    }
    IEnumerator StartBattle(){
        yield return new WaitForSeconds(10f);
        SceneManager.LoadScene("Battle");
    }
}
