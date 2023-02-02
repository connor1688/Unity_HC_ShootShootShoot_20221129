using UnityEngine;

namespace Connor
{
    /// <summary>
    /// 學習列舉
    /// </summary>
    public class LearnMrthod : MonoBehaviour
    {
        //1. 定義列舉
        //2. 儲存在欄位

        // 範例：季節－春夏秋冬
        // 語法：修飾詞　列舉關鍵字　列舉名稱｛選項｝
        public enum Season
        {
            Spring, Summer, Fall, Winter
        }

        public Season gameSeason;

        public Season senson = Season.Summer;

        private void Awake()
        {
            senson = Season.Winter; //將 senson 改為 冬天


            //延遲呼叫 Invoke("方法名稱",延遲秒數);
            Invoke("Spring", 5);

        }


        // 遊戲開始後五秒 senson 變為春天
        private void Spring()
        {
            senson = Season.Spring;
        }
    }
}