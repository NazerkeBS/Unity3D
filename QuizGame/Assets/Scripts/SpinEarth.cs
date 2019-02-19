using UnityEngine;

public class SpinEarth : MonoBehaviour
{


    private bool spin = true;

    private bool spinParent = false;
    private float speed = 1f;
    private bool clockwise = true;
    private float direction = 1f;
    private float directionChangeSpeed = 2f;

    // Update is called once per frame
    void Update()
    {
        if (direction < 1f)
        {
            direction += Time.deltaTime / (directionChangeSpeed / 2);
        }

        if (spin)
        {
            if (clockwise)
            {
                if (spinParent) 
                {
                    transform.parent.transform.Rotate(Vector3.up, (speed * direction) * Time.deltaTime);
                 }

                else {
                    transform.Rotate(Vector3.up, (speed * direction) * Time.deltaTime);
                }

            }
            else
            {
                if (spinParent) {
                    transform.parent.transform.Rotate(-Vector3.up, (speed * direction) * Time.deltaTime);
                }

                else { 
                    transform.Rotate(-Vector3.up, (speed * direction) * Time.deltaTime); 
                }

            }
        }
    }
}
