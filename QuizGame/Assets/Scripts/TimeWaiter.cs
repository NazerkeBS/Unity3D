using System.Collections;
using UnityEngine;
using System;


public class TimeWaiter : MonoBehaviour
{
   public  void Wait(float seconds, Action action) {
        StartCoroutine(WaitSomeTime(seconds, action));
   }
    IEnumerator WaitSomeTime(float time, Action callback) {

        yield return new WaitForSeconds(time);
        callback();
    }
}
