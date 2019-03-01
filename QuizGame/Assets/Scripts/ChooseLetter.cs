using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


/*This class manages the game Level 2 */
public class ChooseLetter : MonoBehaviour
{

    public GameObject letteredObject;
    public GameObject blankObject;
    public GameObject congrats;

    public TimeWaiter waiter;

    private int index = 0;
    private  string result = "";

    void Start() {

        Button[] letteredButtons = letteredObject.GetComponentsInChildren<Button>();
        Button[] blankButtons = blankObject.GetComponentsInChildren<Button>();

        foreach(Button b in letteredButtons) {
            b.onClick.AddListener(() => FillInButtonText(b, blankButtons, letteredButtons));
        }
    }

    void FillInButtonText(Button b, Button[] blankButtons, Button[] letteredButtons) {
        Text t = b.GetComponentInChildren<Text>();
        if(index  <= blankButtons.Length) {
            Text answer = blankButtons[index].GetComponentInChildren<Text>();
            answer.text = t.text;
            index++;
        }
        if(index == blankButtons.Length) {
            result = "";
            for(int i=0; i<blankButtons.Length; i++) {
                Text filledText = blankButtons[i].GetComponentInChildren<Text>();
                result = result + filledText.text;
            }
            checkResult(blankButtons, letteredButtons);
           
        }
     }

    void checkResult(Button[] blankButtons, Button[] letteredButtons)
    {
        if (SceneManager.GetActiveScene().name.Equals("Scene5")) {

            if (result == "BUDAPEST")
            {
                PrintCongrats();
                ScoreCounter.sum += 10;
                CorrectAnswerCounter.sum += 1;
                NextScene("Scene6");
            }

            if (result != "BUDAPEST")
            {
                ClearInputField(blankButtons);
                WrongAnswerCounter.sum += 1;
            }
        }else if (SceneManager.GetActiveScene().name.Equals("Scene6")) {
            if (result == "HIMEJI")
            {
                PrintCongrats();
                ScoreCounter.sum += 10;
                CorrectAnswerCounter.sum += 1;
                NextScene("Scene7");
            }

            if (result != "HIMEJI")
            {
                ClearInputField(blankButtons);
                WrongAnswerCounter.sum += 1;
            }
        }
        else if (SceneManager.GetActiveScene().name.Equals("Scene7"))
        {
            if (result == "BARCELONA")
            {
                PrintCongrats();
                ScoreCounter.sum += 10;
                CorrectAnswerCounter.sum += 1;
                NextScene("Scene8");
            }

            if (result != "BARCELONA")
            {
                ClearInputField(blankButtons);
                WrongAnswerCounter.sum += 1;
            }
        }
        else if (SceneManager.GetActiveScene().name.Equals("Scene8"))
        {
            if (result == "NEWYORK")
            {
                PrintCongrats();
                ScoreCounter.sum += 10;
                CorrectAnswerCounter.sum += 1;
                NextScene("Scene9");
            }

            if (result != "NEWYORK")
            {
                ClearInputField(blankButtons);
                WrongAnswerCounter.sum += 1;
            }
        }
        else if (SceneManager.GetActiveScene().name.Equals("SceneLastLevel2"))
        {
            if (result == "MECCA")
            {
                PrintCongrats();
                ScoreCounter.sum += 10;
                CorrectAnswerCounter.sum += 1;
                waiter = FindObjectOfType<TimeWaiter>();
                waiter.Wait(5, () => { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); });

            }

            if (result != "MECCA")
            {
                ClearInputField(blankButtons);
                WrongAnswerCounter.sum += 1;
            }
        }

    }


    private void NextScene(string sceneName) {
        waiter = FindObjectOfType<TimeWaiter>();
        waiter.Wait(5, () => { SceneManager.LoadScene(sceneName); });
    }

    private void PrintCongrats() {
        Debug.Log("Congrats");
        letteredObject.SetActive(false);
        congrats.SetActive(true);
    }

    private void ClearInputField(Button[] blankButtons) {
        for (int i = 0; i < blankButtons.Length; i++)
        {
            Text clearButtonText = blankButtons[i].GetComponentInChildren<Text>();
            clearButtonText.text = "";
        }
        index = 0;
        result = "";
    }
}
