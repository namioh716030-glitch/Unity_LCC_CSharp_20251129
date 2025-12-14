using UnityEngine;

namespace Lee
{
    /// <summary>
    /// 練習06_迴圈與陣列
    /// </summary>
    /* 宣告一個三維陣列：3*3*2
     * 第一頁放神奇寶貝（其中一個放皮卡丘）
     * 第二頁放楓之谷的怪物名稱（其中一個放菇菇寶貝）
     * 第三頁放英雄聯盟角色名稱（其中一個放蓋倫）
     * 試著取得皮卡丘、菇菇寶貝與蓋倫
     * 試著取得第二頁第一排的第三個
     */
    public class Practise_06_IterArray : MonoBehaviour 
    {
        public string[,,] character = 
        {
            { {"皮丘","皮卡丘","雷丘"}, {"小火龍","火恐龍","噴火龍"} },
            { {"嫩寶","藍寶","紅寶"},{"菇菇仔","菇菇寶貝","緞帶肥肥"} },
            { {"阿璃","阿卡莉","阿姆姆"},{"蓋倫","葛雷夫","加里歐"} }
        };

        private void Start()
        {
            Debug.Log($"<color=#ff3>{character[0, 0, 1]}</color>");
            Debug.Log($"<color=#ff3>{character[1, 1, 1]}</color>");
            Debug.Log($"<color=#ff3>{character[2, 1, 0]}</color>");
            Debug.Log($"<color=#ff3>2-1-3:{character[1, 0, 2]}</color>");
        }
    }
}
