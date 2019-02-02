using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text text;
    private int timeLeft = 30;
    public Image loading;

    static int index = 10;

    void Start()
    {
        StartCoroutine("LoseTime");
        index++;
    }

    private void Update()
    {
        text.text = (""+ timeLeft);

        if(timeLeft <= 0) {
            StopCoroutine("LoseTime");
            text.text = "Time Up";
            SceneManager.LoadScene(index);
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
