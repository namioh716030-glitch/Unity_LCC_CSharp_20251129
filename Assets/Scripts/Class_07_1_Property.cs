using UnityEngine;

namespace Lee
{
    /// <summary>
    /// 屬性 Property
    /// </summary>
    public class Class_07_1_Property : MonoBehaviour
    {
        // 公開的變數:可以讓外部讀取與寫入
        public float moveSpeed = 3.5f;

        // 私人的變數：不允許外部讀取與寫入
        private float turnSpeed = 12.7f;

        // 公開的屬性：允許存取
        public float runSpeed {  get; set; }
        // 私人的屬性：不允許存取
        private float sprintSpeed {  get; set; }
        // 公開的屬性：只有 get 代表唯讀 （只能讀取不能寫入）
        public float jumpSpeed { get; }
    }

}
