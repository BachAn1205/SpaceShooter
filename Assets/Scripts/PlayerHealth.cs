using UnityEngine;

public class PlayerHealth : Health
{
    [Header("UI Settings")]
    public GameObject gameOverUI; // Biến chứa bảng Game Over

    protected override void Die()
    {
        // 1. Bật bảng Game Over hiện lên
        if (gameOverUI != null)
        {
            gameOverUI.SetActive(true);
        }

        // 2. Dừng thời gian game lại (đóng băng mọi thứ)
        Time.timeScale = 0f;

        Debug.Log("Player died");

        // 3. Gọi hàm Die của class cha (để tạo vụ nổ, xóa máy bay...)
        base.Die();

    }
}