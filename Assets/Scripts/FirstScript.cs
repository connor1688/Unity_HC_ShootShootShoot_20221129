// 單行註解：說明、解釋、文字說明的用途
// HH 2022.12.27 O<Z...  
// 程式不會執行
// 程式上下、後(悔學程式了)

using UnityEngine;  // 引用命名空間(倉庫) Unity 遊戲引擎 (API)

// class 類別 等同於腳本 Script
// class 後面接[FirstScript]為腳本名稱，必須與檔案名稱[左上]相同
public class FirstScript : MonoBehaviour
{
    // 腳本都會有一對大括號，放置腳本內容

    // 練習：計算　BMI 
    // 公式：體重(公斤) / 身高(公尺) * 身高(公尺)

    // 福點數 float
    // 兩個參數：身高、體重

    /// <summary>
    /// 計算 BMI
    /// </summary>
    /// <param name="Weight"></param>
    /// <param name="Height"></param>
    /// <returns></returns>


    private float BMI(float Weight, float Height)
    {
        return Weight / (Height * Height);
    }

    // BMI 170 65 

    private void Awake()
    {
        print("我 的 BMI：" + BMI(62, 1.7f));

    }
}



