using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float flySpeed = 10f;
    public int damage = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * flySpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Tìm xem vật thể bị bắn trúng có máu (EnemyHealth) không
        var enemy = collision.GetComponent<EnemyHealth>();
        
        if (enemy != null)
        {
            // Trừ máu kẻ địch
            enemy.TakeDamage(damage);
        }

        // Xóa viên đạn dù trúng hay không
        Destroy(gameObject);
    }
}
