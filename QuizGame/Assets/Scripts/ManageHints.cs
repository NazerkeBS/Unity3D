using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManageHints : MonoBehaviour
{

    public GameObject flag;
    public GameObject flagMusicPlayer;
    public TimeWaiter waiter;

    public GameObject fiftyMusicPlayer;
    public GameObject answerChecker;

    public GameObject backgroundMusic;
    public GameObject modelName;
    public GameObject nameMusicPlayer;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
           
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "HFlag")
                {
                    AudioSource backroundMusicPlay = backgroundMusic.GetComponent<AudioSource>();
                    backroundMusicPlay.playOnAwake = false;
                    backroundMusicPlay.Stop();

                    AudioSource a = flagMusicPlayer.GetComponent<AudioSource>();
                    a.playOnAwake = true;

                    flag.SetActive(true);
                    a.Play();

                    waiter = FindObjectOfType<TimeWaiter>();
                    waiter.Wait(5, () => 
                      {     
                            flag.SetActive(false);
                            a.playOnAwake = false;
                            a.Stop();
                       
                       });

                }
                else if(hit.transform.name == "HFifty")

                {
                    AudioSource backroundMusicPlay = backgroundMusic.GetComponent<AudioSource>();
                    backroundMusicPlay.playOnAwake = false;
                    backroundMusicPlay.Stop();

                    AudioSource a = fiftyMusicPlayer.GetComponent<AudioSource>();
                    a.playOnAwake = true;
                    Button[] buttons = answerChecker.GetComponentsInChildren<Button>();
                    Destroy(buttons[0].gameObject);
                    Destroy(buttons[2].gameObject);
                    a.Play();

                    waiter = FindObjectOfType<TimeWaiter>();
                    waiter.Wait(5, () =>
                    {

                        a.playOnAwake = false;
                        a.Stop();

                    });

                }
                else if (hit.transform.name == "HName") {
                    AudioSource backroundMusicPlay = backgroundMusic.GetComponent<AudioSource>();
                    backroundMusicPlay.playOnAwake = false;
                    backroundMusicPlay.Stop();

                    AudioSource a = nameMusicPlayer.GetComponent<AudioSource>();
                    a.playOnAwake = true;
                    modelName.SetActive(true);
                    a.Play();

                    waiter = FindObjectOfType<TimeWaiter>();
                    waiter.Wait(5, () =>
                    {

                        a.playOnAwake = false;
                        a.Stop();
                        Destroy(modelName.gameObject);

                    });




                }
            }
        }
    }

}
