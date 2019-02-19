using UnityEngine;
using TMPro;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class ManageChoicesAndHints : MonoBehaviour
{
    public GameObject choiceManager;
    public GameObject hintManager;
    public GameObject correctMusicPlayer, wrongMusicPlayer;
    public TimeWaiter waiter;
    public GameObject descriptor;
    public GameObject flag;
    public GameObject modelName;
    public GameObject hintMusicPlayer;
    public GameObject a, d;

    private Transform[] choices;
    private Transform[] hints;
   
    private List<string> names = new List<string>();
    private List<string> nameHints = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        choices = choiceManager.GetComponentsInChildren<Transform>();
        hints = hintManager.GetComponentsInChildren<Transform>();
        names.Add("ChoiceA");
        names.Add("ChoiceB");
        names.Add("ChoiceC");
        names.Add("ChoiceD");

        nameHints.Add("HintFlag");
        nameHints.Add("Fifty");
        nameHints.Add("Name");

    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (names.Contains(hit.transform.name))
                {
                    if(hit.transform.GetComponentInChildren<TextMeshPro>().text == "New York") { 
                        foreach(Transform t in choices)
                        {
                            if (hit.transform.Equals(t)) {
                                musicPlay(correctMusicPlayer);
                                t.GetComponent<Renderer>().material.color = Color.green;
                                ScoreCounter.sum += 5;
                                waiter.Wait(3, () => { SceneManager.LoadScene("Scene22"); });
                            }
                        }
                    }
                    else {
                        foreach (Transform t in choices)
                        {
                            if (hit.transform.Equals(t))
                            {
                                musicPlay(wrongMusicPlayer);
                                t.GetComponent<Renderer>().material.color = Color.red;

                                waiter.Wait(2, () => { foreach (Transform transform in choices) {
                                        Destroy(transform.gameObject);
                                        Destroy(wrongMusicPlayer.gameObject);
                                        enabled = false;
                                        descriptor.SetActive(true);
                                    } });

                                waiter.Wait(5, () => { SceneManager.LoadScene("Scene22"); });

                            }
                        }

                    }
                }
                if (nameHints.Contains(hit.transform.name)) {
                    if (hit.transform.name == "Name") {
                        if (!modelName.activeSelf) {
                            HintMusicPLay();
                            modelName.SetActive(true);
                        }
                        waiter.Wait(5, () => {
                            HintMusicStop();
                            modelName.SetActive(false);
                        });
                    }
                    else if(hit.transform.name == "HintFlag") {
                        if (!flag.activeSelf) {

                            HintMusicPLay();
                            flag.SetActive(true);
                        }
                        waiter.Wait(5, () => {
                            HintMusicStop();
                            flag.SetActive(false);
                        });
                    }
                    else if(hit.transform.name == "Fifty") {
                        if (a.activeSelf) {
                            HintMusicPLay();
                            a.SetActive(false);
                            d.SetActive(false);
                        }
                        waiter.Wait(3, () => {
                            hintMusicPlayer.GetComponent<AudioSource>().Stop();
                        });
                    }

                   
                }

            }
        }
       
       
    }

   private void HintMusicPLay() {
        hintMusicPlayer.GetComponent<AudioSource>().playOnAwake = true;
        hintMusicPlayer.GetComponent<AudioSource>().Play();
    }
    private void HintMusicStop() {
        hintMusicPlayer.GetComponent<AudioSource>().Stop();
    }
    private void musicPlay(GameObject o) {

        o.GetComponent<AudioSource>().playOnAwake = true;
        o.GetComponent<AudioSource>().Play();
    }
}
