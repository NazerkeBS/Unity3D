using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{

    private Text total;

  

   public static int sum = 0;

    void Start()
    {
        
        total = GameObject.Find("Total").GetComponent<Text>();


    }


    private void Update()
    {

        total.text = sum + "";
        
    }


}
