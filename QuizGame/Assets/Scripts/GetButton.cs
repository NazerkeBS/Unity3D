using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GetButton : MonoBehaviour
{
    public TextMesh text;

    public void GetButtonText() {
        if (transform != null)

        {
#pragma warning disable CS0618 // Type or member is obsolete
            text = transform.FindChild("ChoiceB").GetComponent<TextMesh>();
#pragma warning restore CS0618 // Type or member is obsolete

        }
        
    
    }


}
