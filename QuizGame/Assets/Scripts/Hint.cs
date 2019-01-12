using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Hint : MonoBehaviour
{
    [SerializeField]
    private GameObject o;

    // Start is called before the first frame update
    void Start()
    {
       o.SetActive(false);
    }

  
}
