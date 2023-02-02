using UnityEngine;


namespace Connor
{
    /// <summary> 學習判斷式(條件式、選取語句) if 與 switch
    public class LearnCondition : MonoBehaviour
    {
        private void Awake() { }
        
        public bool playerInEnd;      //玩家有沒有走到終點

        public int score = 100;

        public int hp = 100;

        public string weapon = "鏟子";

        public enum Props
        {
            Red, Blue, Yellow
        }

        public Props props = Props.Blue;

        private void Update()
        {
            //範例：如果　玩家走到終點就　過關　否則　就　沒有過關
            if (playerInEnd)
            {
                print("<color=green>過關</Color>");
            }

            // else 大括號內的程式 在 playerInEnd 為 false 會執行
            else
            {
                print("<color=red>尚未通關</cokor>");
            }

            //分數 大於 80 A
            //分數 大於 60 B
            //分數 大於 40 C 補考
            //分數 大於 20 D 當掉
            //E 死當   

            if(score >= 80)
            {
                print("A");
            }
            else if (score >= 60)
            {
                print("B");
            }
            else if (score >= 40)
            {
                print("C，補考");
            }
            else if (score >= 20)
            {
                print("D，當掉");
            }
            else 
            {
                print("死當");
            }






            if (hp >= 80)
            {
                print("安全");
            }
            else if (hp >= 60)
            {
                print("注意");
            }
            else if (hp >= 40)
            {
                print("警告");
            }
            else
            {
                print("危險");
            }
            



            // switch 語法
            // switch (要片段的資料)
            // {
            //      case 值：
            //          資料等於值會執行的程式；
            //          break;
            // }

            //  如果拿 鏟子 可以挖礦
            //  如果拿 斧頭 可以砍木頭
            //  如果拿 弓箭 可以發射弓箭
            switch (weapon)
            {
                case "鏟子":
                    print("可以挖礦!");
                    break;
                case "斧頭":
                    print("可以砍樹!");
                    break;
                case "弓箭":
                    print("可以發射弓箭!");
                    break;
            }

            switch (props)
            {
                case Props.Red:
                    print("補 HP");
                    break;
                case Props.Blue:
                    print("補 SP");
                    break;
                case Props.Yellow:
                    print("補體力");
                    break;
                default:
                    print("這道具無法使用");
                    break;
            }

           
        }
















    }

}
