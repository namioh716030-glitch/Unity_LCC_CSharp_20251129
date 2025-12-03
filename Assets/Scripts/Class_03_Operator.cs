using System;
using UnityEngine;

/// <summary>
/// 課程03：運算子
/// 補充：Unity 欄位屬性、Unity 事件
/// </summary>
public class Class_03_Operator : MonoBehaviour
{
    #region Unity 欄位屬性 Field Attribute
    // C# 變數 = 欄位 Field
    //欄位屬性 Field Attribute
    // [標題(標題字串)]：在屬性面板上顯示標題文
    [Header("等級")]
    public int lv = 1;
    // [提示(提示字串)]：在屬性面板當鼠標停留在變數上時顯示
    [Tooltip("這是武器揮動速度，不建議超過100")]
    public float weaponspeed = 20.5f;
    // [範圍(最小值，最大值)]：為數值型變數建立滑桿
    [Tooltip("售價")][Range(1, 1000)]
    public byte Price = 10;
    // 範圍不能使用在非數值型變數上，會顯示 "Range attribute is not valid on this field type" 錯誤
    [Header("武器名稱")]
    public string weapon = "匕首";
    [Tooltip("武器長度")][Range(1, 8)]
    public float weaponlength = 1.5f;
    // [文字範圍(最小長度，最大長度)]：使用在字串上，設定面板上的文字框範圍
    [TextArea(2, 5)]
    public string itemDescription = "這裡是道具的描述，可以寫很長的文字，可以寫很長的文字，可以寫很長的文字，可以寫很長的文字";

    // 多段欄位屬性
    [Header("血量")]
    [Range(0, 999)]
    public int hp = 100;
    [Header("攻擊力"), Range(0, 100)]
    public float atack = 30.5f;
    // [在屬性面板隱藏]：將公開變數隱藏起來
    [HideInInspector]
    public string password = "我是密碼";
    // [序列化私有欄位]：將私有變數顯示在屬性面板上
    [SerializeField]
    private float mp = 500;
    #endregion
    
    // 使用 Unity 事件
    // 1. 必須在腳本後面添加： MonoBehaviour (繼承自 MonoBehaviour 類別)
    // 2. 使用關鍵字快速完成，例如：輸入 Awake 挑選要使用的事件按 Enter 鍵
    // 喚醒事件：播放遊戲後優先執行的第一個事件，只會執行一次
    // 事件名稱是藍色的 (沒有變色不影響功能)
    private void Awake()
    {
        #region 輸出訊息到 Console 面板的方法與語法類型
        // 將小括號內的訊息輸出到 Unity 的 Console 控制台面板
        // Ctrl + Shift + C 開啟控制台面板
        Debug.Log("哈囉，歡迎來到課程03：運算子"); // 輸出訊息
        Debug.Log(hp);                          // 輸出血量
        Debug.Log("攻擊力：" + atack); // 字串與變數串接輸出)
        Debug.Log($"攻擊力：{atack}"); // 字串內插輸出 (C# 6.0 以上))
        Debug.Log("攻擊力：{attack}"); // 這樣會直接輸出字串，不會讀取變數)
        // Rich Text 富文字格式 (支援 HTML 標籤)
        Debug.Log("<b>這是粗體字</b>"); // 使用 HTML 標籤讓文字變粗)
        Debug.Log("<color=orange>這是顏色字</color>"); // 使用 HTML 標籤讓文字變色))
        // 色碼：#紅紅綠綠藍藍 (16 進位)，數值：0 ~9、A ~ F 越大顏色越亮，#000 黑 #fff 白
        Debug.Log("<color=#55aaff>這是自訂色碼的顏色字</color>");
        Debug.Log("<color=#6fa>這是自訂色碼的顏色字</color>");
        #endregion

        #region 算術運算子示範
        // 運算子示範
        // 1. 算術運算子
        // 加、減、乘、除、餘數
        // +、-、*、/、%
        Debug.Log(10 + 3); // 13
        Debug.Log(10 - 3); // 7
        Debug.Log(10 * 3); // 30
        Debug.Log(10 / 3); // 3.3333333 (除不盡會顯示小數點)
        Debug.Log(10 % 3); // 1 (餘數), 10/3 = 3......1 ，餘數為 1
        #endregion

        #region 區域運算子示範
        Debug.Log("<color=#F93>--- 算術運算子：區域變數 ---</color>");
        // 區域變數：僅在大括號 { } 內有效的變數(不需修飾詞的變數)
        float numberA = 10;
        float numberB = 3;

        Debug.Log(numberA + numberB);
        Debug.Log(numberA - numberB);
        Debug.Log(numberA * numberB);
        Debug.Log(numberA / numberB);
        Debug.Log(numberA % numberB);

        Debug.Log("<color=#f93>--- 比較運算子 ---</color>");
        // 2. 比較運算子，使用後會得到布林值 (true / false)
        int numberC = 100, numberD = 1;

        Debug.Log(numberC > numberD);  // 大於 true
        Debug.Log(numberC < numberD);  // 小於 false
        Debug.Log(numberC >= numberD); // 大於等於 true
        Debug.Log(numberC <= numberD); // 小於等於 false
        Debug.Log(numberC == numberD); // 等於 false
        Debug.Log(numberC != numberD); // 不等於 true
        #endregion
    }
}
