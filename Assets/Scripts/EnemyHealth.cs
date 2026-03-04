using UnityEngine;

// Kế thừa từ Health
public class EnemyHealth : Health
{
    // Ghi đè hàm Die để thêm thông báo
    protected override void Die()
    {
        // MỚI THÊM: Khi kẻ địch nổ tung, trừ đi 1
        LivingEnemyCount--; 
        
        base.Die();
    }
}