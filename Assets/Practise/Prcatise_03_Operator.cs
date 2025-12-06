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
        int numberA = 6;
        int numberB = 2;
        int numberC = (1 + 2);
        int numberD = (numberA / numberB * numberC);
        int numberF = (numberA / (numberB * numberC));

        Debug.Log(numberD);
        Debug.Log(numberF);
    }

}
