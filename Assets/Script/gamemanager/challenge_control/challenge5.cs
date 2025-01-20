using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class challenge5 : MonoBehaviour
{
    Text tex;
    string s1 = "???";
    string s2 = "루왁커피는 누가 처음먹었지? : 바리스타로 클리어";
    // Start is called before the first frame update
    void Start()
    {
        tex = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (challenge.instance.clear[5]) tex.text = s2;
        else tex.text = s1;

    }
}
