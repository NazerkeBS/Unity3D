using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text text;
    public int timeLeft = 30;
    public int index;

    void Start()
    {
        StartCoroutine("LoseTime");
    }

    private void Update()
    {
        text.text = (""+ timeLeft);

        if(timeLeft <= 0) {
            StopCoroutine("LoseTime");
            text.text = "Time Up";
            SceneManager.LoadScene(index+1);
        }
    }

    IEnumerator LoseTime()
    {
        while (true) {

            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }

}
