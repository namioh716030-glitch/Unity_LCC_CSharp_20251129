using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using Lee;

// 命名空間：
// 將類別分類，類似個人倉庫的概念，不同倉庫可以有相同名稱類別
// 語法： namespace 命名空間名稱 { 內容 }
namespace Lee
{
    /// <summary>
    /// 選取陳述式 Selection Statement
    /// 1. if 判斷式
    /// 2. Switch 判斷式
    /// </summary>
    public class Class_05_1_Selection : MonoBehaviour
    {
        [SerializeField, Header("是否開門")]
        private bool isOpen;
        [SerializeField, Header("分數"), Range(0, 100)]
        private int score = 100;
        [SerializeField, Header("武器")]
        private string weapon;
        [SerializeField, Header("血量"), Range(0, 100)]
        private int hp = 0;

        private void Awake()
        {
            // if 判斷式
            // if (布林值) {陳述式}
            if (true)
            {
                Debug.Log("當布林值為 True ，會執行這裡。");
            }

            // 快速完成：輸入 if 選取 if 陳述式按 Enter 或 Tab
            if (false)
            {
                Debug.Log("當布林值為 False ，不會執行這裡而且會有綠蚯蚓。");
            }

        }

        // 更新事件：一秒鐘執行學60次 (60 FPS) Frame Per Second
        private void Update()
        {
            /*常用快捷鍵
             * 1.格式化(排版)： Ctrl + K、D
             * 2.程式碼片段： Ctrl + K、S
             */
            #region 判斷式 if
            Debug.Log("<color=#39f> 更新事件 </color>");

            // 如果 isOpen 布林值等於 True，就顯示已經開門
            if (isOpen)
            {
                Debug.Log("<color=#3f9> 已經開門 </color>");
            }

            // 否則 isOpen 布林值等於 False，就顯示門關了
            else
            {
                Debug.Log("<color=#f93>門關了</color>");
            }

            // 比較運算子，邏輯運算子結果為布林值
            // if 會在最上方 else 在最下方，中間可以有多個 else if
            // 如果分數 >= 60 即通過
            if (score >= 60)
            {
                Debug.Log("<color=#3f3>恭喜你的 C# 課程過了</color>");
            }

            // 否則 如果 分數 >= 40 可以補考
            else if (score >= 40)
            {
                Debug.Log("<color=#f96>你可以補考 C#</color>");
            }

            // 否則 如果 分數 >= 20 可以補考並且做一個小專題
            else if (score >= 20)
            {
                Debug.Log("<color=#ff3>可以補考但是要做一個 C# 小專題</color>");
            }
            // 喜提重修舊好成就一個
            else
            {
                Debug.Log("<color=#f33>恭喜你的 C# 課程重修</color>");
            }
            #endregion

            #region 判斷式 switch
            // switch 判斷式
            // switch (要判斷的值) {陳述式}
            // 快速完成： switch + Tab * 2
            switch (weapon)
            {
                // case 值：
                // 當判斷的值等於值時會執行這裡
                // break; 跳出判斷式
                // 如果武器等於小刀，攻擊力等於 20
                // 蝴蝶刀會與小刀一樣
                case "蝴蝶刀":
                case "小刀":
                    Debug.Log("<color=#ff3>攻擊力：20</color>");
                    break;
                case "美工刀":
                    Debug.Log("<color=#ff3>攻擊力：5</color>");
                    break;
                case "青龍偃月刀":
                    Debug.Log("<color=#f33>攻擊力：666</color>");
                    break;

                // 當 weapon 的值不等於上面的所有值會執行這裡
                default:
                    Debug.Log("<color=#3ff>這是不能使用的武器</color>");
                    break;
            }
            #endregion

            #region 課堂練習判斷式應用
            //課堂練習：
            /* 宣告血量變數
             * 在更新事件內判斷血量
             * 如果血量 >= 10 快死掉了
             * 如果血量 >= 40 警告，快喝水
             * 如果血量 >= 60 健康狀態有狀況
             * 如果血量 >= 80 血量安全
             * 如果血量 == 0  你已經死了
             */
            //判斷式只會執行一個陳述式 if 到 else
            //錯誤語法：順序錯亂，10、40、60、80、0
            //註解快捷鍵：框選程式碼 Ctrl +K、Ctrl + C
            if (hp >= 80)
            {
                Debug.Log("<color=#6ff>血量安全</color>");
            }
            else if (hp >= 60)
            {
                Debug.Log("<color=#6ff>健康狀態有問題</color>");
            }
            else if (hp >= 40)
            {
                Debug.Log("<color=#6ff>警告，快喝水</color>");
            }
            else if (hp >= 10)
            {
                Debug.Log("<color=#6ff>你快死了</color>");
            }
            else if (hp == 0)
            {
                Debug.Log("<color=#6ff>你已經死了</color>");
            }
            // 正確語法：搭配邏輯運算子
            if (hp >= 10 && hp < 40)
            {
                Debug.Log("<color=#6ff>你快死了</color>");
            }
            else if (hp >= 40 && hp < 60)
            {
                Debug.Log("<color=#6ff>警告，快喝水</color>");
            }
            else if (hp >= 60 && hp < 80)
            {
                Debug.Log("<color=#6ff>健康狀態有問題</color>");
            }
            else if (hp >= 80)
            {
                Debug.Log("<color=#6ff>血量安全</color>");
            }
            else if (hp == 0)
            {
                Debug.Log("<color=#6ff>你已經死了</color>");
            } 
            #endregion
        

        }
    }
}

