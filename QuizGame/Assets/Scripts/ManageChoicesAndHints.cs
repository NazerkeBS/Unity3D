using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

/*This class manages game Level 6*/
public class ManageChoicesAndHints : MonoBehaviour
{
    public GameObject choiceManager;
    public GameObject correctMusicPlayer, wrongMusicPlayer;
    public TimeWaiter waiter;
    public GameObject hintMusicPlayer;
    public GameObject d;

    private Transform[] choices;
    private List<string> list;
    void Start()
    {
        choices = choiceManager.GetComponentsInChildren<Transform>();
        list = new List<string>();
        foreach(Transform t in choices) {
            list.Add(t.name);
            
        }
    }
   
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;


            if(Physics.Raycast(ray,out hit)) {
                if (hit.transform.name == "RemoveOne")
                {
                    if (d.activeSelf) {
                        d.SetActive(false);
                        HintMusicPLay();
                        UsedHintCounter.sum += 1;
                        waiter.Wait(3, () => { hintMusicPlayer.GetComponent<AudioSource>().Stop(); });
                    }

                }
            }

            if (Physics.Raycast(ray, out hit))
            {
                {
                    if (SceneManager.GetActiveScene().name=="Scene21") {
                         if (hit.transform.name=="ChoiceC")
                         { 
                            CorrectAnswer(hit);
                         }
                        if (hit.transform.name == "ChoiceB" || hit.transform.name == "ChoiceA" || hit.transform.name == "ChoiceD") 
                        {
                            WrongAnswer(hit);
                        }
                    }
                    if (SceneManager.GetActiveScene().name == "Scene22")
                    {
                        if (hit.transform.name == "ChoiceA") //Athens
                        {
                            CorrectAnswer(hit);
                        }
                        if (hit.transform.name == "ChoiceB" || hit.transform.name == "ChoiceC" || hit.transform.name == "ChoiceD")
                        {
                            WrongAnswer(hit);
                        }
                    }
                    if (SceneManager.GetActiveScene().name == "Scene23")
                    {
                        if (hit.transform.name == "ChoiceB") // London
                        {
                            CorrectAnswer(hit);
                        }
                        if (hit.transform.name == "ChoiceA" || hit.transform.name == "ChoiceC" || hit.transform.name == "ChoiceD")
                        {
                            WrongAnswer(hit);
                        }
                    }
                    if (SceneManager.GetActiveScene().name == "Scene24")
                    {
                        if (hit.transform.name == "ChoiceA") // Astana
                        {
                            CorrectAnswer(hit);
                        }
                        if (hit.transform.name == "ChoiceB" || hit.transform.name == "ChoiceC" || hit.transform.name == "ChoiceD")
                        {
                            WrongAnswer(hit);
                        }
                    }
                    if (SceneManager.GetActiveScene().name == "Scene25")
                    {
                        if (hit.transform.name == "ChoiceD") // London
                        {
                            CorrectAnswer(hit);
                        }
                        if (hit.transform.name == "ChoiceA" || hit.transform.name == "ChoiceC" || hit.transform.name == "ChoiceB")
                        {
                            WrongAnswer(hit);
                        }
                    }

                }
            }
        }
   
    }

   private void HintMusicPLay() {
        hintMusicPlayer.GetComponent<AudioSource>().playOnAwake = true;
        hintMusicPlayer.GetComponent<AudioSource>().Play();
    }
   
    private void MusicPlay(GameObject o) {
        o.GetComponent<AudioSource>().playOnAwake = true;
        o.GetComponent<AudioSource>().Play();
    }
    private void WrongAnswer(RaycastHit hit) {
        MusicPlay(wrongMusicPlayer);
        foreach (Transform t in choices)
        {
            if (t.Equals(hit.transform))
            {
                t.GetComponent<Renderer>().material.color = Color.red;
                WrongAnswerCounter.sum += 1;
            }
        }
        waiter.Wait(3, () => { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); });
    }

    private void CorrectAnswer(RaycastHit hit) {
        MusicPlay(correctMusicPlayer);
        foreach (Transform t in choices)
        {
            if (t.Equals(hit.transform))
            {
                t.GetComponent<Renderer>().material.color = Color.green;
                ScoreCounter.sum += 30;
                CorrectAnswerCounter.sum += 1;
            }
        }
        waiter.Wait(4, () => { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); });
    }
}
