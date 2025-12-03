using UnityEngine;

/// <summary>
/// 課程03：運算子
/// 補充：Unity 欄位屬性、Unity 事件
/// </summary>
public class Class_03_Operator : MonoBehaviour
{
    
    // C# 變數 = 欄位 Field
    //欄位屬性 Field Attribute
    // [標題(標題字串)]：在屬性面板上顯示標題文
    [Header("等級")]
    public int lv = 1;
    // [提示(提示字串)]：在屬性面板當鼠標停留在變數上時顯示
    [Tooltip("這是角色移動速度，不建議超過100")]
    public float moveSpeed = 2.5f;
    // [範圍(最小值，最大值)]：為數值型變數建立滑桿
    [Range(1, 1000)]
    public byte count = 10;
    // 範圍不能使用在非數值型變數上，會顯示 "Range attribute is not valid on this field type" 錯誤
    [Tooltip("武器名稱")]
    public string weapon = "匕首";
    [Range(0, 10)]
    public float weaponlength = 1.5f;
    // [文字範圍(最小長度，最大長度)]：使用在字串上，設定面板上的文字框範圍
    [TextArea(2, 5)]
    public string itemDescription = "這裡是道具的描述，可以寫很長的文字，可以寫很長的文字，可以寫很長的文字，可以寫很長的文字";

    // 多段欄位屬性
    [Header("血量")][Range(0, 999)]
    public int hp = 100;
    [Header("攻擊力")][Range(0, 100)]
    public float atack = 30.5f;
    // [在屬性面板隱藏]：將公開變數隱藏起來
    [HideInInspector]
    public string password = "我是密碼";
    // [序列化私有欄位]：將私有變數顯示在屬性面板上
    [SerializeField]
    private float mp = 500;
}
