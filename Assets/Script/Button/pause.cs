using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    // Start is called before the first frame update
    public void Active_pause()
    {
        Time.timeScale = 0;
    }
    public void Unactive_pause()
    {
        Time.timeScale = 1.0f;
    }
}
