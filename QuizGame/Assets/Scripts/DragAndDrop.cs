using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DragAndDrop : MonoBehaviour
{
    private bool isMouseDown;

    public GameObject choiceToDrag; // correct button 
    public GameObject dropHolder;
    public TimeWaiter waiter;
    public GameObject correctMusicPlayer;
    public GameObject wrongMusicPlayer;

    private Vector3 screenSpace;
    private Vector3 offset;

    private Vector3 initialPos;
    private TextMeshPro text;
    private Renderer shaderColor;
    private Transform[] choices;

    private void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        // Debug.Log(_mouseState);
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo;

            if (choiceToDrag == GetClickedObject(out hitInfo))
            {
                isMouseDown = true;
                screenSpace = Camera.main.WorldToScreenPoint(choiceToDrag.transform.position);
                offset = choiceToDrag.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenSpace.z));
                
            }

        }
        if (Input.GetMouseButtonUp(0))
        {
            isMouseDown = false;
        }

        if (isMouseDown)
        {
            //keep track of the mouse position
            var curScreenSpace = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenSpace.z);

            //convert the screen mouse position to world point and adjust with offset
            var curPosition = Camera.main.ScreenToWorldPoint(curScreenSpace) + offset;

            //update the position of the object in the world
            choiceToDrag.transform.position = curPosition;

            float distance = Vector3.Distance(choiceToDrag.transform.position, dropHolder.transform.position);

            if(distance < 1.2f) {
                text = choiceToDrag.GetComponentInChildren<TextMeshPro>();
                shaderColor = choiceToDrag.GetComponent<Renderer>();

                choiceToDrag.transform.position = dropHolder.transform.position;
                AudioSource backgroundMusic = GameObject.Find("BackgroundMusic").GetComponent<AudioSource>();

                enabled = false;
                if(SceneManager.GetActiveScene().name == "Scene14") {
                    if (text.text == "Rome")
                    {
                        Debug.Log("Correct");
                        CorrectAnswerPlay(backgroundMusic);
                    }
                    else
                    {
                        Debug.Log("Wrong");
                        WrongAnswerPlay(backgroundMusic);

                    }
                    ChangeScene("Scene15");
                }
                if (SceneManager.GetActiveScene().name == "Scene15")
                {
                    if (text.text == "Barcelona")
                    {
                        Debug.Log("Correct");
                        CorrectAnswerPlay(backgroundMusic);
                    }
                    else
                    {
                        Debug.Log("Wrong");
                        WrongAnswerPlay(backgroundMusic);

                    }
                    ChangeScene("Scene16");
                }
                if (SceneManager.GetActiveScene().name == "Scene16")
                {
                    if (text.text == "Toronto")
                    {
                        Debug.Log("Correct");
                        CorrectAnswerPlay(backgroundMusic);
                    }
                    else
                    {
                        Debug.Log("Wrong");
                        WrongAnswerPlay(backgroundMusic);

                    }
                    ChangeScene("Scene17");
                }

            }

        }
       
    }

    //get the clicked object
    private GameObject GetClickedObject(out RaycastHit hit) {
        GameObject target = null;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray.origin, ray.direction*10, out hit)) {
            target = hit.collider.gameObject;
        }
        return target;
    }
   
    /* increment total score */
    private void ScoreIncrement() { 
            ScoreCounter.sum += 20;
    }

    private void CorrectAnswerPlay(AudioSource backgroundMusic) {
     
        AudioSource correctMusicPlay = correctMusicPlayer.GetComponent<AudioSource>();
        correctMusicPlay.playOnAwake = true;
        backgroundMusic.Stop();
        correctMusicPlay.Play();
        shaderColor.material.color = Color.green;
        ScoreIncrement();
    }

    private void WrongAnswerPlay(AudioSource backgroundMusic) {

        AudioSource wrongMusicPlay = wrongMusicPlayer.GetComponent<AudioSource>();
        wrongMusicPlay.playOnAwake = true;
        backgroundMusic.Stop();
        wrongMusicPlay.Play();
        shaderColor.material.color = Color.red;
    }

    private void ChangeScene(string sceneName) {
        waiter = FindObjectOfType<TimeWaiter>();
        GameObject manager = GameObject.Find("manager");
        choices = manager.GetComponentsInChildren<Transform>();
        waiter.Wait(2, () => {
            foreach (Transform t in choices)
            {
                t.gameObject.SetActive(false);
            }
        });
        waiter.Wait(3, () => {
            SceneManager.LoadScene(sceneName);
            wrongMusicPlayer.gameObject.SetActive(false);
            correctMusicPlayer.gameObject.SetActive(false);
        });

    }
}
