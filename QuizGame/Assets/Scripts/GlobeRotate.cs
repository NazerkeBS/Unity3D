using UnityEngine;

public class GlobeRotate : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, Time.deltaTime * 50, 0 ));
    }
}
