using UnityEngine;

public class Hint : MonoBehaviour
{
    public GameObject obj;

    /* Hide the object in the beginning */
    void Start()
    {

        obj.SetActive(false);
    }

  
}
