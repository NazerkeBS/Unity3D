using UnityEngine;
using TMPro;
/*counts correct answers for game stats*/
public class CorrectAnswerCounter : MonoBehaviour
{
    private TextMeshPro correctCounter;

    public static int sum = 0;
    void Start()
    {
        correctCounter = GameObject.Find("CorrectCounter").GetComponent<TextMeshPro>();

    }

    void Update()
    {
        correctCounter.text = sum + "";

    }
}
