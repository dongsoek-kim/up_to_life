using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class challenge1 : MonoBehaviour
{
    Text tex;
    string s1 = "???";
    string s2 = "이번생은 처음이라 : 처음으로 게임시작";
    // Start is called before the first frame update
    void Start()
    {
        tex = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (challenge.instance.clear[1]) tex.text = s2;
        else tex.text = s1;
        
    }
}
 