using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class BackMenu : MonoBehaviour
{
    public Button button;
    void Start()
    {
        button.onClick.AddListener(() => {
            SceneManager.LoadScene("Menu");
        });
        
    }

   
}
