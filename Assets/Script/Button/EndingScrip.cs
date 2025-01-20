using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class EndingScrip : MonoBehaviour
{
    List<string> texs = new List<string>();//스크립트 받을 동적배열
    private Text tex; //텍스트 컴포넌트
    string firstjob; //몇번째 스크립트인지 받을 int 변수
    string lastjob;
    void Start()
    {
        job_sting(Gamemanager.instance.first_job, Gamemanager.instance.ch_job);
        scriptMake(Gamemanager.instance.promotion);
        tex = GetComponent<Text>();
        if (Gamemanager.instance.ch_job == 9 || Gamemanager.instance.ch_job == 10) challenge.instance.clear[2] = true;
        if (Gamemanager.instance.ch_job == 12) challenge.instance.clear[3] = true;
        if (Gamemanager.instance.ch_job == 13) challenge.instance.clear[4] = true;
        if (Gamemanager.instance.ch_job == 14) challenge.instance.clear[5] = true;
        if (Gamemanager.instance.ch_job == 15) challenge.instance.clear[6] = true;
        if (Gamemanager.instance.ch_job == 16) challenge.instance.clear[7] = true;
        if (Gamemanager.instance.ch_job == 17) challenge.instance.clear[8] = true;
        if (Gamemanager.instance.ch_job == 18) challenge.instance.clear[9] = true;
        StartCoroutine("Printing"); //코루틴 실행
    }


    void scriptMake(bool promotion)
    {
        texs.Add("후우..힘든 인생이었어");
        texs.Add("멋모르고" + firstjob + "으로 시작해");
        if(promotion)
        {
            texs.Add(lastjob+"까지 가버리다니..");
        }
        else
        {
            texs.Add("갑자기" + lastjob + "이 되다니..");
        }
        if(Gamemanager.instance.ch_money>20)
        {
            texs.Add("그래도 돈은 많이모았네");
            texs.Add("후회없는 삶이었다..");
            texs.Add("그치만.. 그때가 그립구먼..");
        }
        else
        {
            texs.Add("돈도 없이 힘들게살았지만");
            texs.Add("나만 행복했으면 됐지..");
            texs.Add("그치만.. 그때가 그립구먼..");
        }
    }
   
    void job_sting(int first_job, int last_job)
    {
        switch (first_job)
        {
            case 1:
                firstjob = "의사";
                break;
            case 2:
                firstjob = "대학생";
                break;
            case 3:
                firstjob = "화가";
                break;
            case 5:
                firstjob = "카페알바";
                break;
            case 6:
                firstjob = "헬스트레이너";
                break;
            case 7:
                firstjob = "회사원";
                break;
            case 8:
                firstjob = "알바생";
                break;
        }
        switch (last_job)
        {
            case 9:
                lastjob = "병원원장";
                break;
            case 10:
                lastjob = "고용의";
                break;
            case 11:
                lastjob = "교수";
                break;
            case 12:
                lastjob = "성공한 미술가";
                break;
            case 13:
                lastjob = "무명 미술가";
                break;
            case 14:
                lastjob = "카페 주인";
                break;
            case 15:
                lastjob = "헬스장 주인";
                break;
            case 16:
                lastjob = "임원급 사원";
                break;
            case 17:
                lastjob = "중견급 사원";
                break;
            case 18:
                lastjob = "편의점 사장";
                break;
        }
    }
    IEnumerator Printing()
    {
        for (int i = 0; i < texs.Count; i++)
        {
            for (int j = 0; j < texs[i].Length; j++)
            {
                tex.text += texs[i][j];
                yield return new WaitForSeconds(0.1f);
            }
            tex.text += "\r\n";
            yield return new WaitForSeconds(1f);
            if (i == 2) tex.text = "";
        }
        yield return new WaitForSeconds(5f);
        Gamemanager.instance.Gameend();
    }

}
