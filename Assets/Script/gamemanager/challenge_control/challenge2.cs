using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class challenge2 : MonoBehaviour
{
    Text tex;
    string s1 = "???";
    string s2 = "하얀거탑 : 의사로 게임클리어";
    // Start is called before the first frame update
    void Start()
    {
        tex = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (challenge.instance.clear[2]) tex.text = s2;
        else tex.text = s1;

    }
}