using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowHint : MonoBehaviour
{ 


    public GameObject flag;

    private int timeElapsed = 6;


    public void Show()
    {
        
            StartCoroutine("EnableImage");
        
       

    }
    private void Update()
    {
        if (timeElapsed <= 0)
        {
            StopCoroutine("EnableImage");
            flag.SetActive(false);

        }
    }

    IEnumerator EnableImage()
    {
        while (true)
        {
            flag.SetActive(true);
            yield return new WaitForSeconds(1);
            timeElapsed--;


        }
    }

}
