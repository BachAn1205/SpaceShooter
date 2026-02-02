using UnityEngine;

// Kế thừa từ Health
public class EnemyHealth : Health
{
    // Ghi đè hàm Die để thêm thông báo
    protected override void Die()
    {
        base.Die(); // Gọi hàm Die của cha (để nổ và xóa object)
        Debug.Log("Enemy died"); // In ra console
    }
}