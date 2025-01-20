using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class challenge_button : MonoBehaviour
{
    private void Start()
    {
        gameObject.SetActive(false);
    }
    public void push_chall()
    {
        gameObject.SetActive(true);
    }
    public void push_exit()
    {
        gameObject.SetActive(false);
    }
}
