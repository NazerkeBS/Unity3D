using UnityEngine;
using UnityEngine.SceneManagement;

public class ChoiceManager : MonoBehaviour
{
    public GameObject manager;
    public GameObject correctMusicPlayer;
    public GameObject wrongMusicPlayer;
    public TimeWaiter waiter;

    private Transform[] choices;
    private Renderer shaderColor;

    private void Start()
    {
        choices = manager.GetComponentsInChildren<Transform>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {

                if (SceneManager.GetActiveScene().name == "Scene17" )
                {
                    if (hit.transform.name == "ChoiceB")
                    {
                        enabled = false;
                        foreach (Transform t in choices)
                        {
                            if (hit.transform.Equals(t))
                            {
                                Debug.Log("Correct");
                                correctMusicPlayer.GetComponent<AudioSource>().playOnAwake = true;
                                correctMusicPlayer.GetComponent<AudioSource>().Play();

                                shaderColor = t.GetComponent<Renderer>();
                                shaderColor.material.color = Color.green;
                                ScoreInrement();
                                waiter.Wait(3, () => { SceneManager.LoadScene("Scene18"); });
                            }

                        }
                    }
                    else {
                        enabled = false;
                        Debug.Log("Wrong");
                        foreach (Transform t in choices)
                        {
                            if (hit.transform.Equals(t))
                            {
                                wrongMusicPlayer.GetComponent<AudioSource>().playOnAwake = true;
                                wrongMusicPlayer.GetComponent<AudioSource>().Play();
                                shaderColor = t.GetComponent<Renderer>();
                                shaderColor.material.color = Color.red;
                                waiter.Wait(3, () => { SceneManager.LoadScene("Scene18"); });

                            }
                           
                        }
                    }


                }

            }
        }
    }

    void ScoreInrement() {
        ScoreCounter.sum += 5;
    }
}
