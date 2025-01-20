using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class challenge7 : MonoBehaviour
{
    Text tex;
    string s1 = "???";
    string s2 = "회장은 내 차지야 : 이사로 클리어";
    // Start is called before the first frame update
    void Start()
    {
        tex = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (challenge.instance.clear[7]) tex.text = s2;
        else tex.text = s1;

    }
}
