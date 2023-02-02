﻿using UnityEngine;


namespace Connor
{
    /// <summary>
    /// 學習迴圈
    /// 1. while
    /// 2. for
    /// 3. do while
    /// 4. foreach
    /// </summary>
     public class LearnLoop : MonoBehaviour
    {
        //  經驗值需求表 1 ~ 10 
        //  100
        //  200
        //  300
        //  ...

        public int[] lvExps = new int[10];
               
        
        public void Awake()
        {
            //  迴圈作用：重複執行程式

            //  while 語法：
            //  while (布林值) {程式，當布林值為 true 持續執行}
            int i = 0;
            

            while (i < 5)
            {
                print($"<color=#3366ff>這是 while 迴圈，次數：{i}</color>");
                i++;        //i 遞增：i 加 1
            }

            for (int j = 0; j < 5; j++)
            {
                print($"<color=#3366ff>這是 for 迴圈，次數：{j}</color>");
            }

            for (int c = 0; c < 50; c++)
            {
                print(c);
            }

            //  迴圈 number 從 0 跑到 lvExps 的數量
            for (int number = 0; number < lvExps.Length; number++)
            {
                //lvExps 每一等經驗需求 為 (編號 + 1) * 100
                //lvExps[number] = (number + 1) * 100;
                lvExps[number] = ((number + 1) * number+1*100);
            }





        }
    }

}
