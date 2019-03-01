using UnityEngine;
using UnityEngine.SceneManagement;

/*This class manages the Level 1 game questions */
public class CorrectSceneChanger : MonoBehaviour
{

    public GameObject level1Manager;
    public  GameObject particle;
    public GameObject scoreObject;
    public GameObject congratsObject;
    public GameObject correctMusicPlayer;
    public GameObject description;
    public TimeWaiter waiter;
    public float z;
    public GameObject wrongMusicPlayer;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)) {
                if (SceneManager.GetActiveScene().name == "QuizGame") {
                    Transform[] buttons = level1Manager.GetComponentsInChildren<Transform>();
                    if (hit.transform.name == "ChoiceB") { //Paris
                        CorrectAnswerCounter.sum += 1;
                        InOrderCorrectAnswer(buttons);
                    }
                    else if(hit.transform.name == "ChoiceA" || hit.transform.name == "ChoiceC" || hit.transform.name == "ChoiceD") {
                        WrongAnswerCounter.sum += 1; 
                        InOrderWrongAnswer(buttons);
                    }
                }
                else if (SceneManager.GetActiveScene().name == "Scene2") {
                    Transform[] buttons = level1Manager.GetComponentsInChildren<Transform>();
                    if (hit.transform.name == "ChoiceC") //Pisa
                    {   
                        CorrectAnswerCounter.sum += 1; 
                        InOrderCorrectAnswer(buttons);
                    }
                    else if (hit.transform.name == "ChoiceA" || hit.transform.name == "ChoiceB" || hit.transform.name == "ChoiceD")
                    {
                        WrongAnswerCounter.sum += 1; 
                        InOrderWrongAnswer(buttons);
                    }
                }
                else if (SceneManager.GetActiveScene().name == "Scene3") {
                    Transform[] buttons = level1Manager.GetComponentsInChildren<Transform>();
                    if (hit.transform.name == "ChoiceD") { // Kuala Lumpur
                        CorrectAnswerCounter.sum += 1;
                        InOrderCorrectAnswer(buttons);
                    }
                    else if (hit.transform.name == "ChoiceA" || hit.transform.name == "ChoiceB" || hit.transform.name == "ChoiceC")
                    {
                        WrongAnswerCounter.sum += 1; 
                        HideButtons(buttons);
                        DisableObjects();
                        ActivateAndPlayWrongMusicPlayer();
                        ChangeScene();
                    }
                }
                else if (SceneManager.GetActiveScene().name == "Scene4") {
                    Transform[] buttons = level1Manager.GetComponentsInChildren<Transform>();
                    if (hit.transform.name == "ChoiceA") { //London
                        CorrectAnswerCounter.sum += 1; 
                        InOrderCorrectAnswer(buttons);
                    }
                    else if (hit.transform.name == "ChoiceB" || hit.transform.name == "ChoiceC" || hit.transform.name == "ChoiceD")
                    {
                        WrongAnswerCounter.sum += 1; 
                        HideButtons(buttons);
                        DisableObjects();
                        ActivateAndPlayWrongMusicPlayer();
                        ChangeScene();


                    }
                }
                else if (SceneManager.GetActiveScene().name == "SceneLastLevel1")
                {
                    Transform[] buttons = level1Manager.GetComponentsInChildren<Transform>();
                    if (hit.transform.name == "ChoiceD")//Prague
                    { 
                        CorrectAnswerCounter.sum += 1;
                        InOrderCorrectAnswer(buttons);
                    }
                    else if (hit.transform.name == "ChoiceB" || hit.transform.name == "ChoiceC" || hit.transform.name == "ChoiceA")
                    {
                        WrongAnswerCounter.sum += 1;
                        HideButtons(buttons);
                        DisableObjects();
                        ActivateAndPlayWrongMusicPlayer();
                        ChangeScene();


                    }
                }

            }
        }
    }

    private void InOrderCorrectAnswer(Transform[] buttons) {
        HideButtons(buttons);
        ActivateAndAddScore();
        ChangeScene();
    }
    private void InOrderWrongAnswer(Transform[] buttons) {
        HideButtons(buttons);
        DisableObjects();
        ActivateAndPlayWrongMusicPlayer();
        ChangeScene();
       
    }
    private void HideButtons(Transform[] buttons) {
        foreach (Transform obj in buttons)
        {
            obj.gameObject.SetActive(false);
        }
    }

    private void ActivateAndAddScore() {
        particle.SetActive(true);
        scoreObject.SetActive(true);
        ScoreCounter.sum += 5;
        congratsObject.SetActive(true);
        AudioSource a = correctMusicPlayer.GetComponent<AudioSource>();
        a.playOnAwake = true;
        a.Play();
    }
    private void ChangeScene() {
        waiter.Wait(6, () => { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); });
    }
    private void DisableObjects() {
        particle.SetActive(false);
        scoreObject.SetActive(false);
        congratsObject.SetActive(false);
    }

    private void ActivateAndPlayWrongMusicPlayer() {
        wrongMusicPlayer.GetComponent<AudioSource>().Play();
        RectTransform rectTransform = description.GetComponent<RectTransform>();
        rectTransform.position = new Vector3(rectTransform.position.x, rectTransform.position.y, z);

    }

}
