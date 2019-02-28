using UnityEngine;
using TMPro;

public class UsedHintCounter : MonoBehaviour
{
    private TextMeshPro hintCounter;

    public static int sum = 0;
    void Start()
    {
        hintCounter = GameObject.Find("UsedHintCounter").GetComponent<TextMeshPro>();

    }

    void Update()
    {
      hintCounter.text = sum + "";

    }
}
