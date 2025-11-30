using UnityEngine;

/// <summary>
/// 課程練習二：在「課程_2_資料型態」場景內練習
/// </summary>
//新增一個C#腳本，命名為「Practise_02_DataType」
//建立空物件「練習_2_資料型態」並套用
/*宣告三個公開的變數：
 * 1.使用浮點數 float，預設值為 7.7f 
 * 2.使用倍精度浮點數 double，預設值為 0.12345
 * 3.使用範圍最大的浮點數 decimal，預設值為 1.23456789m
*/
public class Practise_02_DataType : MonoBehaviour
{
    //風險骰子機制設定
    private string itemName = "風險骰子";
    // 骰到失敗機率，私人
    private float failProbability = 75.75f; //失敗機率：0-100%
    // 失敗懲罰成立，私人
    private bool isPunishement = true;
    // 使用浮點數 float，預設值為 7.7f
    // 懲罰倍數
    public float PunishementMultiplier = 7.7f; //根據點數乘以此倍數作為懲罰
    // 使用倍精度浮點數 double，預設值為 0.12345f
    // 骰到幸運機率
    public double LuckyProbability = 0.12345; //幸運機率：0-100%
    // 成功獎勵成立，私人
    private bool isReward = true;
    // 使用範圍最大的浮點數 decimal，預設值為 1.23456789f
    // 骰到安全機率
    // public decimal SafeProbability = 1.23456789m;
    public double SafeProbability = 1.23456789; //安全機率：0-100%
    // 骰到安全獎勵，免除懲罰，預設非安全，私人
    private bool isSafe = false;
}
