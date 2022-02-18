using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Loader : MonoBehaviour
{ public Enemy [] enemies=new Enemy[15];
    public Text description;
    void Start(){     
        description.text=enemies[Player.Instance.bossNumber].toString();
    }
    public void BetQuarter(){
        Player.Instance.bet=Player.Instance.coins/4;
        SceneManager.LoadScene("Battle");
    }
      public void BetThird(){
        Player.Instance.bet=Player.Instance.coins/3;
        SceneManager.LoadScene("Battle");
    }
      public void BetHalf(){
        Player.Instance.bet=Player.Instance.coins/2;
        SceneManager.LoadScene("Battle");
    }
      public void BetThreeQuarters(){
        Player.Instance.bet=Player.Instance.coins*3/4;
        SceneManager.LoadScene("Battle");
    }
}
