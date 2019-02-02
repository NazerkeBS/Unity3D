using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CheckCorrectAnswer : MonoBehaviour
{

    public GameObject checkerObject;
    public GameObject musicPlayer;
    public GameObject musicWrongPlayer;
    public GameObject backgroundMusicPlayer;
    public TimeWaiter waiter;

    // Start is called before the first frame update
    void Start()
    {
        Button[] buttons = checkerObject.GetComponentsInChildren<Button>();
        foreach (Button b in buttons ) {
            b.onClick.AddListener(() => CorrectAnswer(b));
        }

    }

    void CorrectAnswer(Button button) {
        Button[] buttons = checkerObject.GetComponentsInChildren<Button>();
        if (button.name == "ChoiceD")
        {
            Debug.Log("Correct!!!");
            Image image = button.GetComponent<Image>();
            image.color = new Color(0.08677464f, 0.735849f, 0.1039307f);
            AudioSource a  = musicPlayer.GetComponent<AudioSource>();
            a.playOnAwake = true;

            AudioSource backgroundMusicSource = backgroundMusicPlayer.GetComponent<AudioSource>();
            backgroundMusicSource.playOnAwake = false;
            backgroundMusicSource.Stop();

            a.Play();

            waiter = FindObjectOfType<TimeWaiter>();
            ScoreCounter.sum += 5;
            waiter.Wait(4, () => { SceneManager.LoadScene("Scene10"); });

        }
        else
        {
            Debug.Log("Incorrect (:");
            Image image = button.GetComponent<Image>();
            image.color = Color.red;
            AudioSource a = musicWrongPlayer.GetComponent<AudioSource>();
            a.playOnAwake = true;

            AudioSource backgroundMusicSource = backgroundMusicPlayer.GetComponent<AudioSource>();
            backgroundMusicSource.playOnAwake = false;
            backgroundMusicSource.Stop();

            a.Play();

            waiter = FindObjectOfType<TimeWaiter>();
            waiter.Wait(3, () => { SceneManager.LoadScene("Scene10"); });
        }

    }


}
