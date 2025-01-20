using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class challenge6 : MonoBehaviour
{
    Text tex;
    string s1 = "???";
    string s2 = "노!로이더!예스!언더아머! : 헬스장사장으로 클리어";
    // Start is called before the first frame update
    void Start()
    {
        tex = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (challenge.instance.clear[6]) tex.text = s2;
        else tex.text = s1;

    }
}
