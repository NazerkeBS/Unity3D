using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*
 * This class is intended to manage hints in Level 3
 */

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

    private int counter = 0;
    private AudioSource backroundMusicPlay;

    private void Start()
    {
       backroundMusicPlay = backgroundMusic.GetComponent<AudioSource>();
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

                if (hit.transform.name == "HFlag")
                {
                    StopBackgroundMusic();
                    ActivateObjectWithMusic(flag, flagMusicPlayer);
                    SwitchOffObjectAfterSomeTime(flag, flagMusicPlayer);
                    PlayBackgroundMusic();
                }
                else if(hit.transform.name == "HFifty" && counter == 0)

                {
                    StopBackgroundMusic();
                    AudioSource a = fiftyMusicPlayer.GetComponent<AudioSource>();
                    a.playOnAwake = true;
                    a.Play();
                    Button[] buttons = answerChecker.GetComponentsInChildren<Button>();
                    if (SceneManager.GetActiveScene().name.Equals("Scene9")) {
                        buttons[0].gameObject.SetActive(false);
                        buttons[2].gameObject.SetActive(false);
                    }
                    if (SceneManager.GetActiveScene().name.Equals("Scene10"))
                    {
                        buttons[2].gameObject.SetActive(false);
                        buttons[3].gameObject.SetActive(false);
                    }
                    if (SceneManager.GetActiveScene().name.Equals("Scene11")) {
                        buttons[0].gameObject.SetActive(false);
                        buttons[1].gameObject.SetActive(false);
                    }
                    if (SceneManager.GetActiveScene().name.Equals("Scene12"))
                    {
                        buttons[1].gameObject.SetActive(false);
                        buttons[2].gameObject.SetActive(false);
                    }
                    if (SceneManager.GetActiveScene().name.Equals("Scene13"))
                    {
                        buttons[0].gameObject.SetActive(false);
                        buttons[3].gameObject.SetActive(false);
                    }

                    counter++;
                    waiter.Wait(3, () =>
                    {
                        a.playOnAwake = false;
                        a.Stop();
                        PlayBackgroundMusic();
                    });
                   


                }
                else if (hit.transform.name == "HName") {
                    StopBackgroundMusic();
                    ActivateObjectWithMusic(modelName, nameMusicPlayer);
                    SwitchOffObjectAfterSomeTime(modelName, nameMusicPlayer);
                    PlayBackgroundMusic();
                }

            }
        }
    }

    private void PlayBackgroundMusic() {
        if (backroundMusicPlay.playOnAwake == false)
        {
            backroundMusicPlay.playOnAwake = true;
            backroundMusicPlay.Play();
        }
    }

    private void StopBackgroundMusic() {
        backroundMusicPlay.playOnAwake = false;
        backroundMusicPlay.Stop();
    }

    private void ActivateObjectWithMusic(GameObject obj, GameObject musicPlayer) {
        AudioSource a = musicPlayer.GetComponent<AudioSource>();
        a.playOnAwake = true;
        a.Play();
        obj.SetActive(true);
        
    }

    private void SwitchOffObjectAfterSomeTime(GameObject obj, GameObject musicPlayer) {
        AudioSource a = musicPlayer.GetComponent<AudioSource>();
        waiter = FindObjectOfType<TimeWaiter>();
        waiter.Wait(3, () =>
        {
            a.playOnAwake = false;
            a.Stop();
            obj.gameObject.SetActive(false);
        });
    }

   

}
