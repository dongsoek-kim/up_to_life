using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class challenge10 : MonoBehaviour
{
    Text tex;
    string s1 = "???";
    string s2 = "천천히 해봐요:타임오버로 게임오버";
    // Start is called before the first frame update
    void Start()
    {
        tex = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (challenge.instance.clear[10]) tex.text = s2;
        else tex.text = s1;

    }
}
