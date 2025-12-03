using UnityEngine;

///<summary>
///課堂練習一：在「課程_1_變數」場景內練習
///</summary>
/*1.建立一個新的C#腳本，命名為「Practise_01_Variables」
 *2.建立空物件「練習_1_變數」並套用
*/
// 宣告四個變數：
/* 角色名稱 BlackMarketMerchants，預設值為布X前男友，公開
 *角色等級 level，預設值為 5 ，私人 byte
 *角色血量 hp，預設值為 100，公開 ushort
 *販售中 hasSale，預設值為 true，私人
 *跳躍高度 jumpHeight，預設值為 77.5，私人 float
*/
// 販售中物品資訊，預設值如下：
// 1.價格 price，預設值為 999，公開 ushort
/* 2.武器 weapon，預設值為往日之影，公開
 * 武器傷害 weaponDamage，預設值為 -30000，私人 ushort
 * 武器攻速 weaponSpeed，預設值為 3.5，私人 float
 * 武器揮動扣除HP weaponSwingHpCost，預設值為 50，私人 byte
*/
//角色屬性資訊
// 1.角色名稱 playerName，預設值為「布X現男友」，公開
// 2.角色等級 playerLevel，預設值為 30，私人 byte
// 3.角色hp playerHp，預設值為 1500，公開 ushort
// 4.角色所持有金幣 playerCoin，預設值為 1000，私人 ushort
//角色特殊能力
// 4.是否獲得龍魂 hasDragonSoul，預設值為 true，私人

public class Practise_01_Variables : MonoBehaviour
{
    //商人角色資訊
    public string merchantName = "布X前男友";
    public byte merchantLevel = 5;
    public ushort merchantHp = 100;
    private float merchantJumpHeight = 77.5f;
    private float merchantMoveSpeed = 66.5f;
    private bool merchantHasSale = true;
    //販售中物品資訊
    public ushort itemPrice = 999;
    public string itemWeaponName = "往日之影";
    private short itemWeaponDamage = -30000;
    private float itemWeaponSpeed = 3.5f;
    private byte itemWeaponSwingHpCost = 50;
    //玩家角色屬性資訊
    public string playerName = "布X現男友";
    public byte playerLevel = 30;
    public ushort playerHp = 1500;
    private float playerJumpHeight = 38.75f;
    private float playerMoveSpeed = 33.25f;
    public ushort playerCoin = 1000;
    private bool hasDragonSoul = true;
}
