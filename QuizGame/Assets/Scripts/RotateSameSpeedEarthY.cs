using UnityEngine;

public class RotateSameSpeedEarthY : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, Time.deltaTime * 10, 0));

    }
}
