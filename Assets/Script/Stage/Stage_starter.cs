using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Stage_starter : MonoBehaviour
{   
    int map_num;
    public int item_num;
    public int[] item_pos;
    System.Random rd = new System.Random();
    Item_sprite item_Sprite = new Item_sprite();
    // Start is called before the first frame update
    void Start()
    {
        Map_creat();
        item_create();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Map_creat()
    {
        Map_load(-20, 0); Map_load(0, 0);
        Map_load(-20, 10.5f);Map_load(0, 10.5f);
        Map_load(-20, 21);Map_load(0, 21);
    }
    void item_create()
    {
        for(float f=0.5f;f<30;)
        { item_load(f);
            f += 1.5f;
        }
        
    }
    void Map_load(float x,float y)
    {
        map_num = rd.Next(1, 30);
        string s_map_num;
        s_map_num = map_num.ToString();
        string map = "map/map_";
        map = map + s_map_num;
        Instantiate(Resources.Load(map), new Vector3(x, y, 0), Quaternion.identity); //1-1
    }
    void item_load(float y)
    {
        int i;
        int j;
        bool overlap=false;
        for (i = 0; i < 8; i++)
        {
            item_pos[i] = rd.Next(1,39);
            item_num= rd.Next(1, 14) - 1;            
            for (j = 0; j < i; j++) //중복제거를 위한 for문 
            {
                if (item_pos[i] == item_pos[j])
                {
                    i--;
                    overlap = true;
                }
            }
            if (!overlap)
            {
                int x = item_pos[i];
                float _x = ((float)x + 0.5f - 20);
                item_Sprite.item_spawn(_x, y, item_num);
                overlap = false;
            }
        }
    }
}
