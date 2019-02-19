using UnityEngine;

public class RotateSameSpeedEarth : MonoBehaviour
{
    // rotate by z-axis
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, Time.deltaTime * 10));
    }
}
