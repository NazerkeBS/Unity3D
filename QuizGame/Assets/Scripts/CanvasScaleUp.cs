using System.Collections;
using UnityEngine;

public class CanvasScaleUp : MonoBehaviour
{
    public Vector3 minScale = new Vector3(0.005f, 0.005f, 0.005f);
    public Vector3 maxScale = new Vector3(0.98f, 1.0f, 0.98f);
    private float speed = 0.2f;
    private float duration = 5f;


    // Start is called before the first frame update
    IEnumerator Start()
    {
        transform.localScale = minScale;
        yield return RepeatScaleUp(minScale, maxScale, duration);
    }

    private IEnumerator RepeatScaleUp(Vector3 min, Vector3 max, float time) {
        float i = 0.0f;
        float rate = (1.0f / time) * speed;

        while (i < 1.0f) {

            i = i + Time.deltaTime * speed;
            transform.localScale = Vector3.Lerp(min, max, i);
            yield return null;
        }
    }


}
