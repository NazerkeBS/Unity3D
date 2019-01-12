using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChanger : MonoBehaviour
{

   

    public void ChangeScene() {


        SceneManager.LoadScene("Correct");

      


    }

    public void WrongAnswer() {

        SceneManager.LoadScene("Wrong");
      
    }



}
