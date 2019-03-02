using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

/* switch between Levels 1 to 6 */
public class LevelsController : MonoBehaviour
{
    public Button button;
   

    private void Start()
    {
        if (button.name != "Level1" && button.name != "Level2")
        {
            button.interactable = false;
        }
    }
    public void SwitchScene()
    {
       
        GoToLevel(button);

    }

  
    private void GoToLevel(Button b)
    {
        if (b.name == "Level1") {
            SceneManager.LoadScene("QuizGame");
        }else if (b.name == "Level2") {
            SceneManager.LoadScene("Scene5");
        }else if (b.name == "Level3") {
            SceneManager.LoadScene("Scene9");
        }else if (b.name == "Level4") {
            SceneManager.LoadScene("Scene14");
        }else if (b.name == "Level5") {
            SceneManager.LoadScene("Scene17");
        }else if(b.name == "Level6") {
            SceneManager.LoadScene("Scene21");
        }
    }
}
