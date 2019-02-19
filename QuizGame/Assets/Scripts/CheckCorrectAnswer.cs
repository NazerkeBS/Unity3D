using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*
 * This class manages Level 3 game answers and scenes
 */

public class CheckCorrectAnswer : MonoBehaviour
{

    public GameObject checkerObject;
    public GameObject musicCorrectPlayer;
    public GameObject musicWrongPlayer;
    public GameObject backgroundMusicPlayer;
    public TimeWaiter waiter;

    // Start is called before the first frame update
    void Start()
    {
        Button[] buttons = checkerObject.GetComponentsInChildren<Button>();

        foreach (Button b in buttons ) {
            b.onClick.AddListener(() => {
               
                if(SceneManager.GetActiveScene().name == "Scene9") {
                    CorrectAnswerSceneNine(b);
                }
                if(SceneManager.GetActiveScene().name == "Scene10") {
                    CorrectAnswerSceneTen(b);
                }
                if (SceneManager.GetActiveScene().name == "Scene11")
                {
                    CorrectAnswerSceneEleven(b);
                }
                if (SceneManager.GetActiveScene().name == "Scene12")
                {
                    CorrectAnswerSceneTwelve(b);
                }
                if (SceneManager.GetActiveScene().name == "Scene13")
                {
                    CorrectAnswerSceneThirteen(b);
                }

            });
        }
    }

    void CorrectAnswerSceneNine(Button button) {
            if (button.name == "ChoiceD")  // Washington
            {
                 InOrder(button);
                 ChangeSceneAfterSomeTime("Scene10");
            }
            else
            {
                StopBackroundMusic();
                FoundWrongPlay(button);
                ChangeSceneAfterSomeTime("Scene10");
            } 
    }

    void CorrectAnswerSceneTen(Button button)
    {
        if (button.name== "ChoiceA ") // Agra
        {
            InOrder(button);
            ChangeSceneAfterSomeTime("Scene11");
        }
        else
        {
            StopBackroundMusic();
            FoundWrongPlay(button);
            ChangeSceneAfterSomeTime("Scene11");
        }
    }

    void CorrectAnswerSceneEleven(Button button) {
        if (button.name == "ChoiceC") // Schwangau
        {
            InOrder(button);
            ChangeSceneAfterSomeTime("Scene12");
        }
        else
        {
            StopBackroundMusic();
            FoundWrongPlay(button);
            ChangeSceneAfterSomeTime("Scene12");
        }
    }

    void CorrectAnswerSceneTwelve(Button button) {
        if (button.name == "ChoiceD") // Sydney
        {
            InOrder(button);
            ChangeSceneAfterSomeTime("Scene13");
        }
        else
        {
            StopBackroundMusic();
            FoundWrongPlay(button);
            ChangeSceneAfterSomeTime("Scene13");
        }
    }

    void CorrectAnswerSceneThirteen(Button button) {
        if (button.name == "ChoiceB") // Moscow
        {
            InOrder(button);
            ChangeSceneAfterSomeTime("Scene14");
        }
        else
        {
            StopBackroundMusic();
            FoundWrongPlay(button);
            ChangeSceneAfterSomeTime("Scene14");
        }
    }

    private void InOrder(Button button) {
        StopBackroundMusic();
        FoundCorrectPlay(button);
        ScoreCounter.sum += 15;
    }
    private void StopBackroundMusic() {
        AudioSource backgroundMusicSource = backgroundMusicPlayer.GetComponent<AudioSource>();
        backgroundMusicSource.playOnAwake = false;
        backgroundMusicSource.Stop();
    }

    private void FoundCorrectPlay(Button button) {
        Debug.Log("Correct!!!");
        Image image = button.GetComponent<Image>();
        image.color = new Color(0.08677464f, 0.735849f, 0.1039307f);
        AudioSource a = musicCorrectPlayer.GetComponent<AudioSource>();
        a.playOnAwake = true;
        a.Play();
    }

    private void FoundWrongPlay(Button button) {
        Debug.Log("Incorrect (:");
        Image image = button.GetComponent<Image>();
        image.color = Color.red;
        AudioSource a = musicWrongPlayer.GetComponent<AudioSource>();
        a.playOnAwake = true;
        a.Play();
    }

    private void ChangeSceneAfterSomeTime(string sceneName)
    {
        waiter = FindObjectOfType<TimeWaiter>();
        waiter.Wait(4, () => { SceneManager.LoadScene(sceneName); });

    }
}
