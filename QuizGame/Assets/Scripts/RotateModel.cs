using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateModel : MonoBehaviour
{
  

    // rotate the model by z-axis
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, Time.deltaTime * 50));
    }
}
