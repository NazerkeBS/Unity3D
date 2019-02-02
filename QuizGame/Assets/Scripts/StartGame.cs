using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void playGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex  + 1);
        Debug.Log(SceneManager.GetActiveScene().buildIndex + 1);
    
    }

  
}
