using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

    void checkResult(Button[] blankButtons, Button[] letteredButtons) { 
        if(result == "BUDAPEST") {

            Debug.Log("Congrats");
            letteredObject.SetActive(false);
            congrats.SetActive(true);
            ScoreCounter.sum += 5;

            waiter = FindObjectOfType<TimeWaiter>();
            waiter.Wait(5, () => { SceneManager.LoadScene("Scene6"); });

        }

        if (result != "BUDAPEST") {
            for(int i=0; i<blankButtons.Length; i++) {
                Text clearButtonText = blankButtons[i].GetComponentInChildren<Text>();
                clearButtonText.text = "";
            }
            index = 0;
            result = "";
          
        }


    }

  


}
