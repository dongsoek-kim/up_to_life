using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class challenge8 : MonoBehaviour
{
    Text tex;
    string s1 = "???";
    string s2 = "당신은 최고의사람입니다. : 일반회사원으로 클리어";
    // Start is called before the first frame update
    void Start()
    {
        tex = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (challenge.instance.clear[8]) tex.text = s2;
        else tex.text = s1;

    }
}
