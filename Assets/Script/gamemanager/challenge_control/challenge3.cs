using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class challenge3 : MonoBehaviour
{
    Text tex;
    string s1 = "???";
    string s2 = "피카소 : 성공한 미술가로 클리어";
    // Start is called before the first frame update
    void Start()
    {
        tex = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (challenge.instance.clear[3]) tex.text = s2;
        else tex.text = s1;

    }
}
