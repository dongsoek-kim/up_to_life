using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class timelimit : MonoBehaviour
{
    bool pause=false;
    // Update is called once per frame
    void Update()
    {
        if(!pause)
        this.transform.Translate(new Vector3(0, 0.01f, 0));  //이동
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag =="Player")
        {

            SceneManager.LoadScene("main");
            challenge.instance.clear[10] = true;
            Gamemanager.instance.Gameend();

        }
    }
    public void push_pause()
    {
        pause = true;
    }
    public void push_other()
    {
        pause = false;
    }
}
