using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class money_amount : MonoBehaviour
{
    Text tex;
    int money=0;
    String s_money;
    // Start is called before the first frame update

    void Start()
    {
        tex = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        money = Gamemanager.instance.ch_money * 50000;
        s_money = money.ToString();
        tex.text = s_money;
    }
}
