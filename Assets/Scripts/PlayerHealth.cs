using UnityEngine;

public class PlayerHealth : Health
{
    protected override void Die()
    {
        base.Die();
        Debug.Log("Player died");
        // Sau này sẽ thêm Logic Game Over ở đây
    }
}