using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStats : MonoBehaviour
{
    /*It changes the scene when finish is clicked*/
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)) {
                if (hit.transform.name == "Finish") {
                    SceneManager.LoadScene("GameStats");
                }
            }

        }


    }

  
}
