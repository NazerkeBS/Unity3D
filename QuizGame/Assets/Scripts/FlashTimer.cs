using UnityEngine;
using UnityEngine.UI;

public class FlashTimer : MonoBehaviour
{
    private float timeToFlash;
    void Start()
    {
        timeToFlash = Timer.timeLeft;

    }
    // Update is called once per frame
    void Update()
    {
        timeToFlash += Time.deltaTime;
        if(timeToFlash >= 0.5) {
            GetComponent<Text>().enabled = true;
        }
        if(timeToFlash >= 1) {
            GetComponent<Text>().enabled = false;
            timeToFlash = 0;
        
        }

    }
}
