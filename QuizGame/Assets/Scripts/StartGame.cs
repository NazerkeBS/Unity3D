using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void PlayGame() {
        SceneManager.LoadScene("QuizGame");
    }
    public void LevelsScene() {
        SceneManager.LoadScene("Levels");
    }
    public void AboutGame()
    {
        SceneManager.LoadScene("AboutGame");
    }
}
