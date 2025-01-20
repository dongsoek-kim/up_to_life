using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Heart_sprite : MonoBehaviour
{
    public Sprite[] sprites;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Gamemanager.instance.ch_happiness > 1) gameObject.GetComponent<Image>().sprite = sprites[0];
        else if (Gamemanager.instance.ch_happiness > 0) gameObject.GetComponent<Image>().sprite = sprites[1];
        else gameObject.GetComponent<Image>().sprite = sprites[2];
    }
}
