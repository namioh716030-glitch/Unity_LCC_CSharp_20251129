using UnityEngine;

namespace Lee
{
    /// <summary>
    /// 練習存取資料用
    /// </summary>
    public class Class_07_1_GetSetData : MonoBehaviour
    {
        public Class_07_1_Property property;    // 宣告變數：類型與前一個腳本一樣

        private void Awake()
        {
            // 取得另一個類別資料
            Debug.Log(property.moveSpeed);      // 可以取得公開變數
            // Debug.Log(property.turnSpeed);   // 不可取得私人變數

            // 設定另一個類別的資料
            property.moveSpeed = 7.7f;          // 可以設定公開變數
            // property.turnSpeed = 20.2f;      // 不可以設定私人變數
        }
    }

}
