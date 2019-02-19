using UnityEngine;

public class DisableCongrats : MonoBehaviour
{
    public GameObject congrats;

    // Start is called before the first frame update
    void Start()
    {
        congrats.SetActive(false);
    }


}
