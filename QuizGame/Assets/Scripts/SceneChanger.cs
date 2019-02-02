using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChanger : MonoBehaviour
{


    public void ChangeScene() {

        ScoreCounter.sum += 5;
        SceneManager.LoadScene("Correct");

    }

    public void WrongAnswer() {

        SceneManager.LoadScene("Wrong");
      
    }

    public void WrongAnswer2() {
        SceneManager.LoadScene("Wrong2");
    }

    public void WrongAnswer3() {
        SceneManager.LoadScene("Wrong3");
    }

    public void WrongAnswer4() {
        SceneManager.LoadScene("Wrong4");
    }


}
