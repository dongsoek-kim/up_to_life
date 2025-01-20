using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
public class Gamemanager : MonoBehaviour
{
    public static Gamemanager instance = null;
    public int level=1;//현재 몇라운드인지
 /************************************************
    1. 직업
     0.학생	       1.의사           2.대학생
     3.미술가       4.카페 알바      6.헬스 트레이너
     7.회사원       8.편의점 알바    9.병원원장
     10.고용의      11.교수          12.성공한 미술가
     13.실패미술가  14.바리스타      15.헬스장주인
     16.임원사원    17.중견사원      18.자영업사장

    2.전직
     의사->병원원장,고용의,교수
     대학생->교수,중년사원,임원사원,자영업사장
     미술가->교수,성공한미술가,실패한미술가,자영업사장
     카페알바 -> 바리스타, 자영업사장
     헬스트레이터-> 헬스장주인
     회사원-> 중년사원,임원사원,자영업사장
     편의점알바-> 자영업사장
***************************************************/
    public int ch_job=0;
    ///******************************///
    ///         캐릭터 스텟          ///
    ///*****************************///
    public int ch_str = 0;//캐릭터의 힘
    public int ch_int = 0;//캐릭터의 지능
    public int ch_art = 0;//캐릭터의 예술
    public int ch_money = 0;//캐릭터의 돈
    public int ch_happiness = 6;//캐릭터의 행복도
    public int first_job=0;
    public bool promotion = false;

    System.Random rd = new System.Random();
    Animator animator;
    void Awake()
    {
      
        ///싱글톤
        if (instance == null)
            instance = this;

        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
        ///싱글톤
        
    }
    private void Start()
    {
        animator = gameObject.GetComponentInChildren<Animator>();
    }
    public void Get_item(int item_num)
    {
        switch (item_num)
        {
            case 0:
                ch_str += iTem_manager.instance.item_0.str;
                ch_int += iTem_manager.instance.item_0.intel;
                ch_art += iTem_manager.instance.item_0.art;
                ch_money += iTem_manager.instance.item_0.money;
                ch_happiness += iTem_manager.instance.item_0.happiness;
                break;
            case 1:
                ch_str += iTem_manager.instance.item_1.str;
                ch_int += iTem_manager.instance.item_1.intel;
                ch_art += iTem_manager.instance.item_1.art;
                ch_money += iTem_manager.instance.item_1.money;
                ch_happiness += iTem_manager.instance.item_1.happiness;
                break;
            case 2:
                ch_str += iTem_manager.instance.item_2.str;
                ch_int += iTem_manager.instance.item_2.intel;
                ch_art += iTem_manager.instance.item_2.art;
                ch_money += iTem_manager.instance.item_2.money;
                ch_happiness += iTem_manager.instance.item_2.happiness;
                break;
            case 3:
                ch_str += iTem_manager.instance.item_3.str;
                ch_int += iTem_manager.instance.item_3.intel;
                ch_art += iTem_manager.instance.item_3.art;
                ch_money += iTem_manager.instance.item_3.money;
                ch_happiness += iTem_manager.instance.item_3.happiness;
                break;
            case 4:
                ch_str += iTem_manager.instance.item_4.str;
                ch_int += iTem_manager.instance.item_4.intel;
                ch_art += iTem_manager.instance.item_4.art;
                ch_money += iTem_manager.instance.item_4.money;
                ch_happiness += iTem_manager.instance.item_4.happiness;
                break;
            case 5:
                ch_str += iTem_manager.instance.item_5.str;
                ch_int += iTem_manager.instance.item_5.intel;
                ch_art += iTem_manager.instance.item_5.art;
                ch_money += iTem_manager.instance.item_5.money;
                ch_happiness += iTem_manager.instance.item_5.happiness;
                break;
            case 6:
                ch_str += iTem_manager.instance.item_6.str;
                ch_int += iTem_manager.instance.item_6.intel;
                ch_art += iTem_manager.instance.item_6.art;
                ch_money += iTem_manager.instance.item_6.money;
                ch_happiness += iTem_manager.instance.item_6.happiness;
                break;
            case 7:
                ch_str += iTem_manager.instance.item_7.str;
                ch_int += iTem_manager.instance.item_7.intel;
                ch_art += iTem_manager.instance.item_7.art;
                ch_money += iTem_manager.instance.item_7.money;
                ch_happiness += iTem_manager.instance.item_7.happiness;
                break;
            case 8:
                ch_str += iTem_manager.instance.item_8.str;
                ch_int += iTem_manager.instance.item_8.intel;
                ch_art += iTem_manager.instance.item_8.art;
                ch_money += iTem_manager.instance.item_8.money;
                ch_happiness += iTem_manager.instance.item_8.happiness;
                break;
            case 9:
                ch_str += iTem_manager.instance.item_9.str;
                ch_int += iTem_manager.instance.item_9.intel;
                ch_art += iTem_manager.instance.item_9.art;
                ch_money += iTem_manager.instance.item_9.money;
                ch_happiness += iTem_manager.instance.item_9.happiness;
                break;
            case 10:
                ch_str += iTem_manager.instance.item_10.str;
                ch_int += iTem_manager.instance.item_10.intel;
                ch_art += iTem_manager.instance.item_10.art;
                ch_money += iTem_manager.instance.item_10.money;
                ch_happiness += iTem_manager.instance.item_10.happiness;
                break;
            case 11:
                ch_str += iTem_manager.instance.item_11.str;
                ch_int += iTem_manager.instance.item_11.intel;
                ch_art += iTem_manager.instance.item_11.art;
                ch_money += iTem_manager.instance.item_11.money;
                ch_happiness += iTem_manager.instance.item_11.happiness;
                break;
            case 12:
                ch_str += iTem_manager.instance.item_12.str;
                ch_int += iTem_manager.instance.item_12.intel;
                ch_art += iTem_manager.instance.item_12.art;
                ch_money += iTem_manager.instance.item_12.money;
                ch_happiness += iTem_manager.instance.item_12.happiness;
                break;
            case 13:
                ch_str += iTem_manager.instance.item_13.str;
                ch_int += iTem_manager.instance.item_13.intel;
                ch_art += iTem_manager.instance.item_13.art;
                ch_money += iTem_manager.instance.item_13.money;
                ch_happiness += iTem_manager.instance.item_13.happiness;
                break;
            case 14:
                ch_str += iTem_manager.instance.item_14.str;
                ch_int += iTem_manager.instance.item_14.intel;
                ch_art += iTem_manager.instance.item_14.art;
                ch_money += iTem_manager.instance.item_14.money;
                ch_happiness += iTem_manager.instance.item_14.happiness;
                break;
            case 15:
                ch_str += iTem_manager.instance.item_15.str;
                ch_int += iTem_manager.instance.item_15.intel;
                ch_art += iTem_manager.instance.item_15.art;
                ch_money += iTem_manager.instance.item_15.money;
                ch_happiness += iTem_manager.instance.item_15.happiness;
                break;
            case 16:
                ch_str += iTem_manager.instance.item_16.str;
                ch_int += iTem_manager.instance.item_16.intel;
                ch_art += iTem_manager.instance.item_16.art;
                ch_money += iTem_manager.instance.item_16.money;
                ch_happiness += iTem_manager.instance.item_16.happiness;
                break;
            case 17:
                ch_str += iTem_manager.instance.item_17.str;
                ch_int += iTem_manager.instance.item_17.intel;
                ch_art += iTem_manager.instance.item_17.art;
                ch_money += iTem_manager.instance.item_17.money;
                ch_happiness += iTem_manager.instance.item_17.happiness;
                break;
            case 18:
                ch_str += iTem_manager.instance.item_18.str;
                ch_int += iTem_manager.instance.item_18.intel;
                ch_art += iTem_manager.instance.item_18.art;
                ch_money += iTem_manager.instance.item_18.money;
                ch_happiness += iTem_manager.instance.item_18.happiness;
                break;
            case 19:
                ch_str += iTem_manager.instance.item_19.str;
                ch_int += iTem_manager.instance.item_19.intel;
                ch_art += iTem_manager.instance.item_19.art;
                ch_money += iTem_manager.instance.item_19.money;
                ch_happiness += iTem_manager.instance.item_19.happiness;
                break;
            case 20:
                ch_str += iTem_manager.instance.item_20.str;
                ch_int += iTem_manager.instance.item_20.intel;
                ch_art += iTem_manager.instance.item_20.art;
                ch_money += iTem_manager.instance.item_20.money;
                ch_happiness += iTem_manager.instance.item_20.happiness;
                break;
            case 21:
                ch_str += iTem_manager.instance.item_21.str;
                ch_int += iTem_manager.instance.item_21.intel;
                ch_art += iTem_manager.instance.item_21.art;
                ch_money += iTem_manager.instance.item_21.money;
                ch_happiness += iTem_manager.instance.item_21.happiness;
                break;
            case 22:
                ch_str += iTem_manager.instance.item_22.str;
                ch_int += iTem_manager.instance.item_22.intel;
                ch_art += iTem_manager.instance.item_22.art;
                ch_money += iTem_manager.instance.item_22.money;
                ch_happiness += iTem_manager.instance.item_22.happiness;
                break;
            case 23:
                ch_str += iTem_manager.instance.item_23.str;
                ch_int += iTem_manager.instance.item_23.intel;
                ch_art += iTem_manager.instance.item_23.art;
                ch_money += iTem_manager.instance.item_23.money;
                ch_happiness += iTem_manager.instance.item_23.happiness;
                break;
            case 24:
                ch_str += iTem_manager.instance.item_24.str;
                ch_int += iTem_manager.instance.item_24.intel;
                ch_art += iTem_manager.instance.item_24.art;
                ch_money += iTem_manager.instance.item_24.money;
                ch_happiness += iTem_manager.instance.item_24.happiness;
                break;
            case 25:
                ch_str += iTem_manager.instance.item_25.str;
                ch_int += iTem_manager.instance.item_25.intel;
                ch_art += iTem_manager.instance.item_25.art;
                ch_money += iTem_manager.instance.item_25.money;
                ch_happiness += iTem_manager.instance.item_25.happiness;
                break;
            default:
                break;
        }
        if (ch_happiness > 6)
            ch_happiness = 6;
        if (ch_happiness < 1)
            Gameend();
    }
    public void Gameover()//게임오버시 초기값으로 돌려준다
    {
        level = 1;
        ch_job = 0;
        ch_str = 0;//캐릭터의 힘
        ch_int = 0;//캐릭터의 지능
        ch_art = 0;//캐릭터의 예술
        ch_money = 0;//캐릭터의 돈
        ch_happiness = 6;//캐릭터의 행복도
        first_job = 0;
        promotion = false;
    }


    public void GameStart()
    {
        /*if(Dlc have)//스타터팩을 구매햇을시 초기 능력치 ++
            ch_speed += 10;
            ch_jump_speed += 330;
            ch_str += 0;
            ch_int += 0;
            ch_art += 0;
            ch_health += 0;
            ch_money += 0;
            ch_happiness += 0;                 
        */
            
        SceneManager.LoadScene("Stage1");
    }
    public void Stageclear()
    {
        List<int> job = new List<int>();
        level++;
        if (level == 2)
        {
            
            if (ch_int > 20) job.Add(1);//의사
            if (ch_int > 10) job.Add(2);//대학생
            if (ch_art > 15) job.Add(3);//화가
            if (ch_art > 5 && ch_str > 5) job.Add(4);//카페알바
            if (ch_str > 15) job.Add(6);//헬스트레이너
            if (ch_int > 5) job.Add(7);//회사원
            if(job.Count!=0)
            {
                ch_job= job[rd.Next(0, job.Count)];
                job.Clear();
            }
            else ch_job = 8;//알바생
            first_job = ch_job;
            SceneManager.LoadScene("Stage2");
        }
        else if (level == 3)
        {
            Debug.Log("스테이지3");
            if (first_job==1 && ch_int > 30) job.Add(11);//병원원장
            if (first_job == 1 && ch_int > 25) job.Add(10);//고용의
            if (first_job==2 && ch_int > 20) job.Add(11);//교수
            if (first_job == 3 && ch_art > 20 && ch_money>5) job.Add(12);//성공미술가
            if (first_job == 3 && ch_art > 20) job.Add(13);//실패미술가
            if (first_job == 4 && ch_str> 8 && ch_art > 8&& ch_money>5) job.Add(14);//바리스타
            if (first_job == 6 &&ch_str > 10&&ch_money>5) job.Add(15);//헬스장주인
            if (first_job == 7 &&ch_int > 20&&ch_money>8) job.Add(16);//임원급사원
            if (first_job == 7 && ch_int > 20) job.Add(17);//중년사원
            if (job.Count != 0)
            {
                ch_job = job[rd.Next(0, job.Count)];
                job.Clear();
                promotion = true;
            }
            else
                ch_job = 18;//자영업사장
            SceneManager.LoadScene("Stage3");
        }
        else if (level == 4)
        SceneManager.LoadScene("EndingPage");

    }
    public void Gameend()
    {
        Gameover();
        SceneManager.LoadScene("main");
    }
}

