using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(StartBattle());
    }
    IEnumerator StartBattle()
    {Debug.Log("xxx");
        yield return new WaitForSeconds(10f);
        Debug.Log("yyy");
        SceneManager.LoadScene("Battle");
    }
}
