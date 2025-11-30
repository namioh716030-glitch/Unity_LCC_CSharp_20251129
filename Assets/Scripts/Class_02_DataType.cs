using UnityEngine;

// 三條斜線是摘要（XML 語言）用來做簡短說明，可以加在類別、方法、屬性等的上方
/// <summary>
/// 認識 C# 的基本資料型態
/// </summary>
public class Class_02_DataType : MonoBehaviour
{
    // 變數語法：
    // 修飾詞 變數資料類型 變數名稱 指定 預設值;
    /* 四大常用資料類型：
     * 整數： int (integer) 沒有小數點的數值，範例：-20、0、100
     * 浮點數： float (floating point) 有小數點的數值，範例：-3.5、0.0、2.75
     * 文字串： string 文字或字元的集合，範例："Hello World"、"123"、"@#$%"
     * 布林值： bool (boolean) 只有兩種狀態，範例：true(真)、false(假)
    */
    public int count = 7;          // 整數：沒有小數點的數值，範例：-20、0、100
    public float moveSpeed = 15.25f; // 浮點數：有小數點的數值，範例：-3.5、0.0、2.75 後面要加 f
    public float turnSpeed = 30.5f; // 浮點數：有小數點的數值，範例：-3.5、0.0、2.75 後面要加 f
    public string character = "Gay"; // 文字串：文字或字元的集合，範例："Hello World"、"123"、"@#$%"
    public bool IsDead = false;    // 布林值：只有兩種狀態，範例：true(真)、false(假)
    public bool gameOver = true;   // 布林值：只有兩種狀態，範例：true(真)、false(假)

    // 整數資料類型的其他種類：
    public byte level = 50;      // byte：0~255 的整數，大小為 8 byte 
    public uint coins = 9999;    // uint：0 以上的整數，大小為 32 byte 
    public ulong exp = 50000000;  // ulong：0 以上的整數，大小為 64 byte
    public short hp = 30000;    // short：-32,768~32,767 的整數，大小為 16 byte
    public ushort mp = 45000;   // ushort：0~65,535 的整數，大小為 16 byte

    // 字串與字元：
    public string playerName = "MADAO"; // 字串：文字或字元的集合
    public char grade = 'M';               // 字元：單一字元，使用單引號包住，範例：'A'、'中'、'@'

    // 溢位測試：
    // 例如：public sbyte damage = -130;   // sbyte：-128~127 的整數，大小為 8 byte
}
