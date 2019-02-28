using UnityEngine;
using TMPro;

public class AttemptCounter : MonoBehaviour
{
    private TextMeshPro attemptCounter;

    void Start()
    {
        attemptCounter = GameObject.Find("AttemptCounter").GetComponent<TextMeshPro>();
    }

    void Update()
    {
        int sum = CorrectAnswerCounter.sum + WrongAnswerCounter.sum;
        attemptCounter.text = sum + ""; 
    }
}
