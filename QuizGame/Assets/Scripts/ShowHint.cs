using System.Collections;
using UnityEngine;

public class ShowHint : MonoBehaviour
{ 

    public GameObject flag;

    private int timeElapsed = 4;

    /* When the button is clicked, show the hidden object */
    public void Show()
    {
        timeElapsed = 4;
        StartCoroutine("EnableObject");
        UsedHintCounter.sum += 1;
    }
    private void Update()
    {
        if (timeElapsed <= 0)
        {
            flag.SetActive(false);
            StopCoroutine("EnableObject");
        }
    }

    IEnumerator EnableObject()
    {
        while (true)
        {
            flag.SetActive(true);
            yield return new WaitForSeconds(1);
            timeElapsed--;

        }
    }

}
