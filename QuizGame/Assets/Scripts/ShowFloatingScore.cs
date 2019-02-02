using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowFloatingScore : MonoBehaviour
{
    public float destroyTime = 3f;
    public GameObject floatingText;


    // Start is called before the first frame update
    void Start()
    {
        Destroy(floatingText, destroyTime);
                
    }


}
