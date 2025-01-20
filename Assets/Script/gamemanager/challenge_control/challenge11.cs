using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class challenge11 : MonoBehaviour
{
    Text tex;
    string s1 = "???";
    string s2 = "당신이 최고: 모든 도전과제 클리어";
    // Start is called before the first frame update
    void Start()
    {
        tex = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (challenge.instance.clear[11]) tex.text = s2;
        else tex.text = s1;

    }
}
