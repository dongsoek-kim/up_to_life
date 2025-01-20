    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class iTem_manager : MonoBehaviour
{
    // Start is called before the first frame update
    public static iTem_manager instance = null;



    public class Item
    {
        public int item_nomber;
        public int job;
        public int str;//캐릭터의 힘
        public int intel;//캐릭터의 지능
        public int art;//캐릭터의 예술
        public int money;//캐릭터의 돈
        public int happiness;//캐릭터의 행복도
        public Item(int get_item_nomber, int get_str, int get_intel, int get_art, int get_money, int get_happiness)
        {
            item_nomber = get_item_nomber;
            str = get_str;
            intel = get_intel;
            art = get_art;
            money = get_money;
            happiness = get_happiness;
        }
    };
    /****************************************************************
    *****************************************************************
    * 1. 공통아이템
    *  0.야구공 1.돈  2.책  3.하트  4.핸드폰 
    *  5.우유  6.팔찌   7.장갑 8.돈주머니 9.자전거
    * 2. 직업아이템
    *   학생 :  10.피아노, 11.색연필
    *   의사 : 12.청진기  13.그래프
    *   대학생 : 14.컴퓨터, 15.축구공  
    *   미술가 : 16.기타 , 17.붓, 18.팔레트
    *   카페알바 : 19.커피 ,20.도넛
    *   헬스트레이터 : 21.덤벨, 22.줄넘기
    *   회사원 :  23.서류 24.큐브
    *   편의점알바 : 25.치킨
    *                               힘 지 예 돈 건
    ******************************************************************/
    public Item item_0 = new Item(0, 1, 0, 0, 0, 0);
    public Item item_1 = new Item(1, 0, 0, 0, 1, 0);
    public Item item_2 = new Item(2, 0, 1, 0, 0, 0);
    public Item item_3 = new Item(3, 0, 0, 0, 0, 1);
    public Item item_4 = new Item(4, 0,-1, 0, 0, 2);
    public Item item_5 = new Item(5, 1, 0, 0, 0, 1);
    public Item item_6 = new Item(6, 0, 1, 1, 1, 0);
    public Item item_7 = new Item(7, 1, 1, 1, 0, 0);
    public Item item_8 = new Item(8, 0, 0, 0, 2, 0);
    public Item item_9 = new Item(9, 2, 0, 0, 0,-1);
    public Item item_10 = new Item(10, 0, 2, 2, 0, 0);
    public Item item_11 = new Item(11, 0, 0, 2, 0, 0);
    public Item item_12 = new Item(12, 0, 4, 1, 2,-1);
    public Item item_13 = new Item(13, 0, 6, 0, 4,-2);
    public Item item_14 = new Item(14, 0, 4, 0, 0,-1);
    public Item item_15 = new Item(15, 0, 0, 0, 1, 2);
    public Item item_16 = new Item(16, 0, 2, 3, 1, 1);
    public Item item_17 = new Item(17, 0, 2, 4, 1,-1);
    public Item item_18 = new Item(18, 0, 2, 5, 2,-1);
    public Item item_19 = new Item(19, 2, 0, 2, 2, 0);
    public Item item_20 = new Item(20, 4, 0, 2, 4,-1);
    public Item item_21 = new Item(21, 6, 0, 0, 3,-1);
    public Item item_22 = new Item(22, 4, 0, 0, 3, 0);
    public Item item_23 = new Item(23, 4, 0, 0, 4,-1);
    public Item item_24 = new Item(24, 2, 0, 0, 0, 1);
    public Item item_25 = new Item(25, 0, 0, 0, 2,-1);
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
}
