using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchModelScript : MonoBehaviour
{
    //20 models which are stored in the array of GameObject 
    public GameObject avatar1, avatar2;

    int whichAvatarIsOn = 1;
     
    // game initialization
    void Start()
    {
        avatar1.gameObject.SetActive(true);
        avatar2.gameObject.SetActive(false);

        
    }
    // to go to the next element
    public void switchAvatar()
    {
        switch (whichAvatarIsOn) {

            case 1:
                whichAvatarIsOn = 2;
                avatar1.gameObject.SetActive(false);
                avatar2.gameObject.SetActive(true);
                break;

            case 2:

                whichAvatarIsOn = 1;

                avatar1.gameObject.SetActive(true);
                avatar2.gameObject.SetActive(false);
                break;


        }

    }


}
