using UnityEngine;
using TMPro;

public class WrongAnswerCounter : MonoBehaviour
{
    private TextMeshPro wrongCounter;

    public static int sum = 0;
    void Start()
    {
        wrongCounter = GameObject.Find("WrongCounter").GetComponent<TextMeshPro>();

    }

    void Update()
    {
        wrongCounter.text = sum + "";

    }
}
