using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    //Public variables editable in unity
    public string targetScene = "";

    //Condition
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Condition 2
        if (collision.CompareTag("Player"))
        {
            SwitchScene();
        }
    }

    //Action
    public void SwitchScene()
    {
        SceneManager.LoadScene(targetScene);
    }

}
