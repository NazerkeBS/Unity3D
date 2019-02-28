using UnityEngine;

public class RotateByY : MonoBehaviour
{
   
    // rotate model by Y 
    void Update()
    {
        transform.Rotate(new Vector3(0,  Time.deltaTime * 30, 0));

    }
}
