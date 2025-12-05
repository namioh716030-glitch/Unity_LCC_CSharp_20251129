using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

/// <summary>
/// 方法 Method
/// 中文：方法、函式、函數、功能
/// 英文：Method、Function (Unity 多數使用 Method)
/// </summary>
public class Class_04_Method : MonoBehaviour
{
    private void Awake()    // 私有 無傳回 喚醒事件
    {
        #region 方法基本語法與參數呼叫
        // 呼叫方法：方法沒有呼叫不會執行
        // 方法名稱(參數1, 參數2, ...);
        FirstFunction();    //呼叫第一次
        FirstFunction();    //呼叫第二次
        FirstFunction();    //呼叫第三次
        // 呼叫有參數的方法：小括號內要放入對應數量的引數
        // UseSkill(); // 錯誤：缺少引數
        UseSkill("火球術", 50);    // 呼叫有參數的方法
        UseSkill("冰箭術", 30);
        UseSkill("新阿姆斯特朗旋風噴射阿姆斯特朗砲", 100);
        // 呼叫有預設參數的方法：可以不用填 (選填式參數)
        SpawnEnemy();          // 使用預設參數
        SpawnEnemy("史萊姆");  // 使用自訂參數

        Fire(300);            // 發射物件速度與預設參數名稱
        Fire(600, "砲彈");    // 發射物件速度與自訂參數名稱
        // 有多個選擇性參數時的呼叫
        // 買紅水，50個
        BuyItem(count: 50);
        // 買紅水，30個
        // BuyItem(30); 錯誤：30 會直接帶入到 item 參數導致資料類型不符合
        BuyItem(count: 30);
        // 買藍水，50個
        BuyItem("藍水");
        // 買藍水，100個
        BuyItem("藍水", 100);
        #endregion

        
        // 呼叫有傳回方法
        // 第一種：把結果放到區域變數內
        int number9 = Square(9);
        Debug.Log($"<color=#a33>9 的平方 {number9}</color>");
        // 第二種：把傳回方法當作該傳回類型使用
        Debug.Log($"<color=#a33>7 的平方 {Square(7)}</color>");

        ///<summary>
        ///課堂練習：傳回語法練習 BMI 身高除以體重的平方
        ///</summary>
        BMI(60, 1.68f);
        BMI(87, 165f);
        Debug.Log($"<color=#f93> 體重除以身高平方 {BMI(60, 1.68f)}</color>");
        Debug.Log($"<color=#f93> 體重除以身高平方 {BMI(87, 1.65f)}</color>");

        Move();
        Move(50.5f);
    }

    // 框選要整理的程式： Ctrl + K、S → #region 快速完成程式碼片段
    #region 方法的基本語法與參數 
    // 方法：
    // 包含一系列程式碼的區塊
    // 方法語法：
    // 修飾詞 傳回資料類型 方法名稱 (參數1，參數2，…，參數N) { 程式碼區塊 }
    // 方法命名規則： Unity 建議使用大駝峰命名法 (Pascal Case)
    // void 無傳回：使用此方法不會傳回任何資料
    private void FirstFunction()    // 方法名稱：FirstFunction
    {
        Debug.Log("這是第一個方法"); // 訊息視窗顯示文字
    }

    // 參數語法：與區域變數相同 資料類型 參數名稱 (習慣用小寫或者加底線開頭)
    private void UseSkill(string skill, float cost) // 私有 無傳回 有一個字串參數 skill
    {
        Debug.Log($"<color=#39f> 施放技能：{skill}</color>");    // 引用參數
        Debug.Log($"<color=#ff0> 技能消耗：{cost}</color>");    // 引用參數
    }

    private void SpawnEnemy(string enemy = "哥布林")
    {
        Debug.Log($"<color=#f33>生成敵人：{enemy}</color>");
    }

    // 沒有預設值稱為：必要參數，有預設值稱為選擇性參數
    // 選擇性參數要寫在右邊
    //private void Fire(string fire, int speed)
    //{
    //    Debug.Log($"<color=#6f6>發射物件：{fire}，速度：{speed}</color>");
    //}

    /// <summayr>
    /// 發射物件方法
    /// </summayr>
    /// <param name = "speed">發射速度</param>
    /// <param name = "fire">要發射的物件</param>
    private void Fire(int speed, string fire = "砲彈")
    {
        Debug.Log($"<color=#f6f>發射物件：{fire}，速度：{speed}</color>");
    }

    /// <summary>
    /// 購買道具
    /// </summary>
    /// <param name="item">道具名稱</param>
    /// <param name="count">道具數量</param>
    private void BuyItem(string item = "紅水", int count = 50)
    {
        Debug.Log($"<color=#3f3>購買商品:{item}，數量:{count}</color>");
    }
    #endregion

    // 傳回方法：傳回類型不是 void 呼叫該方法會獲得結果
    // 傳回方法必須在 {} 內使用 return 關鍵字將結果傳回
    /// <summary>
    /// 範例「平方」
    /// </summary>
    /// <param name="number"></param>
    /// <returns>數字的平方</returns>
    private int Square(int number)
    {
        return number * number;
    } 
    
    private float Square(float number)
    {
        return number * number;
    }

    /// <summary>
    /// BMI的計算練習
    /// </summary>
    /// <param name="weight">體重：公斤</param>
    /// <param name="height">身高：公尺</param>
    /// <returns></returns>
    private float BMI(float weight, float height)
    {
        return weight / Square(height);
    }

    // 名稱不能重複，類別，變數與方法
    private void Test() { }
    // private Void Test() { }  // 名稱重複的錯誤

    // 方法多載 function overload
    // 參數的類型或數量不同
    // 零個參數
    ///<summary>
    ///移動
    ///</summary>
    private void Move()
    {
        Debug.Log("<color=#3ff>移動中</color>");
    }
    // 一個參數
    /// <summary>
    /// 移動方法並指定速度
    /// </summary>
    /// <param name="speed"></param>
    private void Move(float speed)
    {
        Debug.Log($"<color=#3ff>移動中，速度：{speed}</color>");
    }
}