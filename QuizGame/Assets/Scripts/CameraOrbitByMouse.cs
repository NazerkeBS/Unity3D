using UnityEngine;

public class CameraOrbitByMouse : MonoBehaviour
{
    private float speed = 8f;
    private float distance = 2f;
    public Transform target;
    private Vector2 input;

    // Update is called once per frame
    void Update()
    {
        input += new Vector2(Input.GetAxis("Mouse X") * speed, Input.GetAxis("Mouse Y") * speed);

        Quaternion rotation = Quaternion.Euler(0, input.y, input.x);

        Vector3 position = target.position - (rotation * Vector3.forward * distance);

        transform.localRotation = rotation;
        transform.localPosition = position;
    }
}
