using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Loader : MonoBehaviour
{
    public Text description;
    Enemy enemy;
    void Start()
    {      
            enemy=BattleManager.Instance.player.GetEnemy();  
      description.text=enemy.toString();
        StartCoroutine(StartBattle());
    }
    IEnumerator StartBattle(){
        yield return new WaitForSeconds(10f);
        SceneManager.LoadScene("Battle");
    }
}
