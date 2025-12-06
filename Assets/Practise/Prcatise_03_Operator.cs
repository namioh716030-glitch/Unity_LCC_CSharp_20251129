using UnityEngine;


/// <summary>
/// 課程作業_03_運算子練習
/// </summary>
/* 條件：
 * 建立空物件「練習_3_運算子」並套用
 * 計算「6 / 2(1+2)
*/
public class Prcatise_03_Operator : MonoBehaviour
{
    private void Awake()
    {
        float numberA = 6;
        float numberB = 2;
        float numberC = (1 + 2);
        float numberD = (numberA / numberB * numberC);

        Debug.Log(numberD);
    }
}
