using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("GameOver in side trigger");

        //for just delay
        for (int i = 0; i<=500000000; i++) ;


        SceneManager.LoadScene("Main");

    }

}
