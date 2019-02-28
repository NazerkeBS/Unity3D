using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ScrollAboutGamePanel : MonoBehaviour
{
    public GameObject panel;

    public void OpenPanel() { 
        if(panel != null) {
            Animator animator = panel.GetComponent<Animator>();
            if(animator != null) {
             
                bool isOpen = animator.GetBool("open");
               
                animator.SetBool("open", !isOpen);
             
            }
        }
    }

 
}
