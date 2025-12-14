using UnityEngine;

namespace Lee
{
    /// <summary>
    /// 課堂練習05_判斷式，迴圈與列舉
    /// </summary>
    /* 使用 Switch 練習下方的題目
     * 宣告血量變數
     * 在更新事件內判斷血量
     * 1.如果血量 >=10 快死掉了
     * 2.如果血量 >=40 警告，快喝水
     * 3.如果血量 >=60 健康狀態有問題
     * 4.如果血量 >=80 血量安全
     * 5.如果血量 <= 0 你已經死了
     */
    public class Practise_05_Switch : MonoBehaviour
    {
        [SerializeField, Header("血量"), Range(0, 100)]
        private int hp = 100;

        private void Update()
        {
            switch (hp)
            {
                case (>= 80):
                    Debug.Log("<color=#3f6>血量安全</color>");
                    break;
                case (>= 60):
                    Debug.Log("<color=#9f3>健康狀態有問題</color>");
                    break;
                case (>= 40):
                    Debug.Log("<color=#ff3>警告，快喝水</color>");
                    break;
                case (>= 10):
                    Debug.Log("<color=#f63>快死掉了</color>");
                    break;
                case (<= 0):
                    Debug.Log("<color=#fff>你已經死了</color>");
                    break;
            }
        }
    }
}
