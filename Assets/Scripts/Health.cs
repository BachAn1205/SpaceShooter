using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject explosionPrefab; // Prefab nổ
    public int defaultHealthPoint = 3; // Máu mặc định
    private int healthPoint;

    // Khi game bắt đầu, gán máu hiện tại = máu mặc định
    private void Start()
    {
        healthPoint = defaultHealthPoint;
    }

    // Hàm nhận sát thương
    public void TakeDamage(int damage)
    {
        if (healthPoint <= 0) return; // Nếu đã chết thì thôi

        healthPoint -= damage; // Trừ máu

        if (healthPoint <= 0)
        {
            Die(); // Hết máu thì gọi hàm chết
        }
    }

    // Hàm Chết (cho phép lớp con chỉnh sửa - virtual)
    protected virtual void Die()
    {
        // Tạo vụ nổ nếu có
        if (explosionPrefab != null)
        {
            var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(explosion, 1f);
        }
        
        // Xóa vật thể
        Destroy(gameObject);
    }
}