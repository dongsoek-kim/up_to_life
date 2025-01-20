using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class challenge4 : MonoBehaviour
{
    Text tex;
    string s1 = "???";
    string s2 = "고흐가 될 사람 : 실패한 미술가로 클리어";
    // Start is called before the first frame update
    void Start()
    {
        tex = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (challenge.instance.clear[4]) tex.text = s2;
        else tex.text = s1;

    }
}
