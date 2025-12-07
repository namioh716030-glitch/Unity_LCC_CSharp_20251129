using UnityEngine;

/// <summary>
/// 課程作業_04_方法練習
/// </summary>
/* 條件：
 * 建立空物件「練習_4_方法」並套用
 * 宣告兩個方法傳回布林值
 * 方法內要包含一段 Debug.Log
 * 一個傳回 true
 * 一個傳回 flase
*/
public class Practise_04_Method : MonoBehaviour 
{
    
    // 判斷是否通關
    public bool CheckClearCondition(int collectedItems, int requiredItems = 10)
    {
        if (collectedItems >= requiredItems)
        {
            Debug.Log("✔ 通關成功！收集到 " + collectedItems + " / " + requiredItems);
            return true;
        }
        else
        {
            Debug.Log("✖ 失敗！目前只有 " + collectedItems + " / " + requiredItems + "，請重來！");
            return false;
        }
    }

    // 測試用：遊戲開始時執行
    void Start()
    {
        int playerItems = 8; // 模擬玩家收集的物品數量

        if (CheckClearCondition(playerItems))
        {
            // 這裡可以呼叫下一關邏輯
            Debug.Log("載入下一關...");
        }
        else
        {
            // 這裡可以呼叫重來邏輯
            Debug.Log("重新開始關卡...");
        }
    }

    // KID 示範
    private void Awake()
    {
        Debug.Log($"<color=#f93>True {ReturnTrue()}</color>");
        Debug.Log($"<color=#f93>Flase {ReturnFalse()}</color>");
    }
    /// <summary>
    /// 布林值 True
    /// </summary>
    /// <returns></returns>
    private bool ReturnTrue()
    {
        return true;
    }
    /// <summary>
    /// 布林值 Flase
    /// </summary>
    /// <returns></returns>
    private bool ReturnFalse()
    {
        return false;
    }
}
