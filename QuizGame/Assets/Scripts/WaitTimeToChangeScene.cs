using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class WaitTimeToChangeScene : MonoBehaviour
{
    public int index;
    private int waitFor = 5;
   

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("WaitTime");
    }

    // Update is called once per frame
    void Update()
    {
        if ( waitFor<=0) {
            StopCoroutine("WaitTime");
            SceneManager.LoadScene(index + 1);
    
        }
    }

    IEnumerator WaitTime()
    {
        while (true) {
           

            yield return new WaitForSeconds(1);
            waitFor--;


        }

    }
}
