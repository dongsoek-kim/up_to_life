using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class challenge9 : MonoBehaviour
{
    Text tex;
    string s1 = "???";
    string s2 = "행복했으면 됬어요 : 편의점 주인으로 클리어";
    // Start is called before the first frame update
    void Start()
    {
        tex = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (challenge.instance.clear[9]) tex.text = s2;
        else tex.text = s1;

    }
}