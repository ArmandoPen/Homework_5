using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public string levelName;

    public void NextLevel()
    {
        SceneManager.LoadScene(levelName);
    }

    //Used by a Trigger Collider 
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            NextLevel();
        }
    }
}


