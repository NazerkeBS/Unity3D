using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDoor : MonoBehaviour
{

    private float t = 0f;
    private Vector3 startPos;
    private Vector3 target;
    private float timeToReach = 3.0f;
    public float distance;
    public float xx;

    public Camera mainCamera;

    void Start()
    {

        startPos = transform.position;
        target = new Vector3(transform.position.x+xx, transform.position.y, transform.position.z+distance);
    }


    void Update()
    {
        t = t + Time.deltaTime / timeToReach;
        transform.position = Vector3.Lerp(startPos, target, t);
        /* move the camera to the main question canvas */
        if (Input.GetKeyDown("up"))
        {
            mainCamera.transform.rotation = Quaternion.Euler(0, 0, 0);

        }

       

    }
}
