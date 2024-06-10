using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player")
        {
            // Debug.Log("you finished"); // testing if finish line works
            SceneManager.LoadScene(0);        }
        

    }
   
}
