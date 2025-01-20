using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Item_sprite : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite[] sprites;

    System.Random rd = new System.Random();
    public int item_num;
    public int ch_job;
    // Start is called before the first frame update

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        ch_job = Gamemanager.instance.ch_job;
        if (item_num > 9) job_item();
        spriteRenderer.sprite = sprites[item_num];
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void item_spawn(float x, float y,int _item_num)
    {
        GameObject obj=Instantiate(Resources.Load("system/itembox"), new Vector3(x, y, 0), Quaternion.identity) as GameObject; //1-1
        Item_sprite gs = obj.GetComponent<Item_sprite>();
        gs.item_num = _item_num;
    }
    void job_item()
    {
        if (ch_job == 0)
            item_num = rd.Next(10, 11);
        else if (ch_job == 1 || ch_job == 9 || ch_job == 10)
            item_num = rd.Next(12, 13);
        
        else if (ch_job == 2 || ch_job == 11)
            item_num = rd.Next(14, 15);
        else if (ch_job == 3 || ch_job == 12 || ch_job == 13)
            item_num = rd.Next(16, 18);
        else if (ch_job == 4 || ch_job == 14)
            item_num = rd.Next(19, 20);
        else if (ch_job == 6 || ch_job == 15)
            item_num = rd.Next(21, 22);
        else if (ch_job == 7 || ch_job == 16 || ch_job == 17)
            item_num = rd.Next(23, 24);
        else if (ch_job == 8 || ch_job == 18)
        {
            Debug.Log("편돌이 아이템");
            item_num = 25;
        }
    }
}
    

