using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*This class manages the game level 5*/
public class InputFieldHandler : MonoBehaviour
{
    public GameObject input;
    public TimeWaiter waiter;
    public GameObject correctMusicPlayer;

    private TMP_InputField txt;
     
    private ColorBlock colorBlock;

    private void Start()
    {
        txt = input.GetComponent<TMP_InputField>();

    }

    public void Show()
    {
        colorBlock = txt.colors;
        string str = txt.text;

        if(SceneManager.GetActiveScene().name == "Scene17") {

            if (str.ToLower() == "milan")
            {
                txt.interactable = false;
                AudioSource a = correctMusicPlayer.GetComponent<AudioSource>();
                a.playOnAwake = true;
                a.Play();
                ScoreCounter.sum += 25;
                CorrectAnswerCounter.sum += 1;
                waiter.Wait(3, () => { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); });

            }
            else
            {
                Debug.Log("Incorrect");
                colorBlock.normalColor = Color.red;
                txt.colors = colorBlock;
            }
        }
        else if (SceneManager.GetActiveScene().name == "Scene18")
        {

            if (str.ToLower() == "istanbul")
            {
                txt.interactable = false;
                AudioSource a = correctMusicPlayer.GetComponent<AudioSource>();
                a.playOnAwake = true;
                a.Play();
                ScoreCounter.sum += 25;
                CorrectAnswerCounter.sum += 1;
                waiter.Wait(3, () => { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); });

            }
            else
            {
                Debug.Log("Incorrect");
                colorBlock.normalColor = Color.red;
                txt.colors = colorBlock;
            }
        }
        else if (SceneManager.GetActiveScene().name == "Scene19")
        {

            if (str.ToLower() == "dubai")
            {
                txt.interactable = false;
                AudioSource a = correctMusicPlayer.GetComponent<AudioSource>();
                a.playOnAwake = true;
                a.Play();
                ScoreCounter.sum += 25;
                CorrectAnswerCounter.sum += 1;
                waiter.Wait(3, () => { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); });

            }
            else
            {
                Debug.Log("Incorrect");
                colorBlock.normalColor = Color.red;
                txt.colors = colorBlock;
            }
        }
        else if (SceneManager.GetActiveScene().name == "Scene20")
        {

            if (str.ToLower() == "beijing")
            {
                txt.interactable = false;
                AudioSource a = correctMusicPlayer.GetComponent<AudioSource>();
                a.playOnAwake = true;
                a.Play();
                ScoreCounter.sum += 25;
                CorrectAnswerCounter.sum += 1;
                waiter.Wait(3, () => { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); });
            }
            else
            {
                Debug.Log("Incorrect");
                colorBlock.normalColor = Color.red;
                txt.colors = colorBlock;
            }
        }
        else if (SceneManager.GetActiveScene().name == "Scene20B")
        {
            if (str.ToLower() == "newyork" || str.ToLower() == "new york")
            {
                txt.interactable = false;
                AudioSource a = correctMusicPlayer.GetComponent<AudioSource>();
                a.playOnAwake = true;
                a.Play();
                ScoreCounter.sum += 25;
                CorrectAnswerCounter.sum += 1;
                waiter.Wait(3, () => { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); });
            }
            else
            {
                Debug.Log("Incorrect");
                colorBlock.normalColor = Color.red;
                txt.colors = colorBlock;
            }
        }

    }
}
