using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class WaitTimeToChangeScene : MonoBehaviour
{
    static  int index = 6;
    private int waitFor = 6;
   

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("WaitTime");
        index++;
    }

    // Update is called once per frame
    void Update()
    {
        if ( waitFor<=0) {
            StopCoroutine("WaitTime");
            //index = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(index);
            
    
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
