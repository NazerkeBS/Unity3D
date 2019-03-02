using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

/* This class controls the swtiching of levels*/
public class SwitchLevelController : MonoBehaviour
{
    public GameObject obj;

    private Button button;
    private TextMeshProUGUI txt;


    void Start()
    {
        button = obj.GetComponent<Button>();
        txt = obj.GetComponentInChildren<TextMeshProUGUI>();
        if (button.name == "Level2") {
            txt.text = "Lock L 2";
        }else if (button.name == "Level3") {
            txt.text = "Lock L 3";
        }else if (button.name == "Level4") {
            txt.text = "Lock L 4";
        }else if(button.name == "Level5") {
            txt.text = "Lock L 5";
        }
        else if (button.name == "Level6")
        {
            txt.text = "Lock L 6";
        }


    }
    private void Update()
    {
       if(SceneManager.GetActiveScene().name == "QuizGame"|| SceneManager.GetActiveScene().name == "Scene2" || SceneManager.GetActiveScene().name == "Scene3" || SceneManager.GetActiveScene().name == "Scene4" || SceneManager.GetActiveScene().name == "SceneLastLevel1")
        {
            if (ScoreCounter.sum >= 5)
            {
                txt.text = "Play L 2";
                button.enabled = true;
            }
            else
            {
                button.enabled = false;
            }
        }
        if (SceneManager.GetActiveScene().name == "Scene5" || SceneManager.GetActiveScene().name == "Scene6" || SceneManager.GetActiveScene().name == "Scene7" || SceneManager.GetActiveScene().name == "Scene8" || SceneManager.GetActiveScene().name == "SceneLastLeve2")
        {
            if (ScoreCounter.sum >= 15)
            {
                txt.text = "Play L 3";
                button.enabled = true;
            }
            else
            {
                button.enabled = false;
            }
        }
        if (SceneManager.GetActiveScene().name == "Scene9" || SceneManager.GetActiveScene().name == "Scene10" || SceneManager.GetActiveScene().name == "Scene11" || SceneManager.GetActiveScene().name == "Scene12" || SceneManager.GetActiveScene().name == "Scene13")
        {
            if (ScoreCounter.sum >= 40)
            {
                txt.text = "Play L 4";
                button.enabled = true;
            }
            else
            {
                button.enabled = false;
            }
        }
        if (SceneManager.GetActiveScene().name == "Scene14" || SceneManager.GetActiveScene().name == "Scene15" || SceneManager.GetActiveScene().name == "Scene16" || SceneManager.GetActiveScene().name == "Scene16A" || SceneManager.GetActiveScene().name == "Scene16B")
        {
            if (ScoreCounter.sum >= 75)
            {
                txt.text = "Play L 5";
                button.enabled = true;
            }
            else
            {
                button.enabled = false;
            }
        }
        if (SceneManager.GetActiveScene().name == "Scene17" || SceneManager.GetActiveScene().name == "Scene18" || SceneManager.GetActiveScene().name == "Scene19" || SceneManager.GetActiveScene().name == "Scene20" || SceneManager.GetActiveScene().name == "Scene20B")
        {
            if (ScoreCounter.sum >= 125)
            {
                txt.text = "Play L 6";
                button.enabled = true;
            }
            else
            {
                button.enabled = false;
            }
        }
    }

    public void MoveLevel2() {  
        SceneManager.LoadScene("Scene5");
    }
    public void MoveLevel3() {
        SceneManager.LoadScene("Scene9");
    }
    public void MovelLevel4()
    {
        SceneManager.LoadScene("Scene14");
    }
    public void MoveLevel5() {
        SceneManager.LoadScene("Scene17");
    }
    public void MoveLevel6()
    {
        SceneManager.LoadScene("Scene21");
    }
}
