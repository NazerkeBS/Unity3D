using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkyBox : MonoBehaviour
{
    public Material[] skybox;
    private int timeElapsed = 4;
    public void  Start()
    {
        StartCoroutine("WaitTime");

    }
    public void Update()
    {
        if(timeElapsed <= 0) {
            StopCoroutine("WaitTime");
            int x = Random.Range(0, skybox.Length);
            RenderSettings.skybox = skybox[x];
        }

    }

    IEnumerator WaitTime() {
        while (true) {
            yield return new WaitForSeconds(1);
            timeElapsed--;
        }

    }
}
