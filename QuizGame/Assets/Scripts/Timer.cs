using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text text;
    public static int timeLeft = 0;
    public Image loading;

    void Start()
    {
        if (WithoutTimer.IsEnabled) {
            timeLeft += 30;
            StartCoroutine("LoseTime");
        }
        else {

            text.text = "";
        }

    }

    private void Update()
    {
        if (WithoutTimer.IsEnabled) {

            text.text = timeLeft + "";

            if (timeLeft <= 0)
            {
                StopCoroutine("LoseTime");
                text.text = "Time is Up";
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
        else {
            text.text = "";
        }

    }

    IEnumerator LoseTime()
    {
        while (true) {

            yield return new WaitForSeconds(1);
            float fill = (float)timeLeft / 32;
            loading.fillAmount = fill;
            timeLeft--;
           

        }
    }
}
