using UnityEngine;
using UnityEngine.SceneManagement;

/* This class manages the hints in  Level 5*/
public class ChoiceManager : MonoBehaviour
{
    public GameObject manager;
    public GameObject hintMusicPlayer;
    public GameObject flag;
    public GameObject modelName;
    public GameObject map;
    public GameObject firstLetter;
    public TimeWaiter waiter;

    private Transform[] hints;
    private Renderer shaderColor;
   

    private void Start()
    {
        hints = manager.GetComponentsInChildren<Transform>();
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
                if (hit.transform.name == "HintFlagObject")
                {
                    AudioSource a = hintMusicPlayer.GetComponent<AudioSource>();
                    a.playOnAwake = true;
                    a.Play();
                    foreach (Transform hint in hints)
                    {
                        shaderColor = hit.transform.gameObject.GetComponent<Renderer>();

                        shaderColor.material.color = new Color(0.5f, 0.4f,0.7f,1f);
                        if(hint.name == "HintFlagObject") {
                            flag.SetActive(true);
                            UsedHintCounter.sum += 1;
                            waiter.Wait(4, () => { flag.SetActive(false);  a.playOnAwake = false;  a.Stop(); });
                        }
    
                    }
                }
                if (hit.transform.name == "HintModelNameObject")
                {
                    AudioSource a = hintMusicPlayer.GetComponent<AudioSource>();
                    a.playOnAwake = true;
                    a.Play();
                    foreach (Transform hint in hints)
                    {
                        shaderColor = hit.transform.gameObject.GetComponent<Renderer>();
                        shaderColor.material.color = new Color(0.5f, 0.4f, 0.7f, 1f);
                        if (hint.name == "HintModelNameObject")
                        {
                            modelName.SetActive(true);
                            UsedHintCounter.sum += 1;
                            waiter.Wait(4, () => { modelName.SetActive(false); a.playOnAwake = false; a.Stop(); });
                        }

                    }
                }
                if (hit.transform.name == "HintMapObject")
                {
                    AudioSource a = hintMusicPlayer.GetComponent<AudioSource>();
                    a.playOnAwake = true;
                    a.Play();
                    foreach (Transform hint in hints)
                    {
                        shaderColor = hit.transform.gameObject.GetComponent<Renderer>();
                        shaderColor.material.color = new Color(0.5f, 0.4f, 0.7f, 1f);
                        if (hint.name == "HintMapObject")
                        {
                            map.SetActive(true);
                            UsedHintCounter.sum += 1;
                            waiter.Wait(5, () => { map.SetActive(false); a.playOnAwake = false; a.Stop(); });
                        }

                    }
                }
                if (hit.transform.name == "HintFistLetterObject")
                {
                    AudioSource a = hintMusicPlayer.GetComponent<AudioSource>();
                    a.playOnAwake = true;
                    a.Play();
                    foreach (Transform hint in hints)
                    {
                        shaderColor = hit.transform.gameObject.GetComponent<Renderer>();
                        shaderColor.material.color = new Color(0.5f, 0.4f, 0.7f, 1f);
                        if (hint.name == "HintFistLetterObject")
                        {
                            firstLetter.SetActive(true);
                            UsedHintCounter.sum += 1;
                            waiter.Wait(4, () => { firstLetter.SetActive(false); a.playOnAwake = false; a.Stop(); });
                        }

                    }
                }
            }

        }
    }
}
