using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CorrectSceneChanger : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)) {
                if (SceneManager.GetActiveScene().name == "QuizGame" && hit.transform.name == "ChoiceB") {


                    SceneManager.LoadScene("Correct");

                }
                else if (SceneManager.GetActiveScene().name == "QuizGame" && (hit.transform.name == "ChoiceA" || hit.transform.name == "ChoiceC" || hit.transform.name == "ChoiceD"))
                {
                    
                    SceneManager.LoadScene("Wrong");

                }
                else if (SceneManager.GetActiveScene().name == "Scene2") {
                   if(hit.transform.name == "ChoiceC")
                    {
                       
                        SceneManager.LoadScene("Correct");
                    }
                    else {
                        SceneManager.LoadScene("Wrong2");
                    }
                }else if (SceneManager.GetActiveScene().name == "Scene3") { 
                    if(hit.transform.name == "ChoiceD") {
                        SceneManager.LoadScene("Correct");
                    }
                    else {

                        SceneManager.LoadScene("Wrong3");
                    }
                }else if (SceneManager.GetActiveScene().name == "Scene4") { 
                    if(hit.transform.name == "ChoiceA") {
                        SceneManager.LoadScene("Correct");
                    }
                    else {
                        SceneManager.LoadScene("Wrong4");
                    }
                }

            }
        }
    }
  
  
}
