using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithoutTimer : MonoBehaviour
{
   public static bool  IsEnabled = true;
   public void SetNoTimer() {
        IsEnabled = false;
   }
}
