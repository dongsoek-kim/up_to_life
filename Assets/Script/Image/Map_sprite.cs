using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map_sprite : MonoBehaviour
{

    private SpriteRenderer spriteRenderer;
    public Sprite[] sprites;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        //if (Gamemanager.instance.ch_job == 1)
        spriteRenderer.sprite = sprites[3];

    }

    // Update is called once per frame
    void Update()
    {

    }
}
