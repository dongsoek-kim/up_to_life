using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamestart : MonoBehaviour
{
   public void Click_Gamestart()
    {

        challenge.instance.clear[1] = true;
        Gamemanager.instance.GameStart();   
    }
}
