using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class challenge : MonoBehaviour
{
    public bool[] clear = new bool[13];

    public static challenge instance = null;
    void Awake()
    {
        ///싱글톤
        if (instance == null)
            instance = this;

        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
        ///싱글톤

    }
 
    void Start()
    {
        for (int i = 0; i < 13; i++)
        {
            clear[i] = false;
        }   
    }

}
