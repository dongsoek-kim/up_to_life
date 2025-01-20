using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

            gameObject.SetActive(false);

    }

    // Update is called once per frame
    public void push_pause()
    {
        gameObject.SetActive(true);
    }
    public void push_playing()
    {

        gameObject.SetActive(false);

    }
    public void push_restart()
    {

        gameObject.SetActive(false);
        Gamemanager.instance.Gameover();
        Gamemanager.instance.GameStart();
    }
    public void push_main()
    {
        gameObject.SetActive(false);
        Gamemanager.instance.Gameend();
    }
}
