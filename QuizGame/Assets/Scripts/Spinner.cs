using UnityEngine;
using UnityEngine.UI;

public class Spinner : MonoBehaviour
{
    public float multiplier = 2.2f;
    public bool isStopped;
    public TimeWaiter waiter;
    public Button btn;
    public GameObject hintMusicPlayer;
    public GameObject flag;

    private bool clicked;

    private float rand;

    private void Start()
    {
        clicked = false;

    }
    // Update is called once per frame
    void Update()
    {
        btn.onClick.AddListener(() => { clicked = true; });
        if (clicked) {
            hintMusicPlayer.GetComponent<AudioSource>().playOnAwake = true;
            hintMusicPlayer.GetComponent<AudioSource>().Play();

            rand = Random.Range(0.01f, 0.15f);
            multiplier += rand;
            transform.Rotate(Vector3.forward, 1 * multiplier);
            isStopped = false;

            waiter.Wait(4, () => {
                multiplier = 2.2f;
                isStopped = true;
                flag.SetActive(true);
                enabled = false;
            });
        }
    }
}
