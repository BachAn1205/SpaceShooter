using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleFlow : MonoBehaviour
{
    [Header("UI Panels")]
    public GameObject gameWinUI; // Kéo CanvasGameWin vào đây

    [Header("Game Objects")]
    public GameObject player; // Kéo máy bay Player vào đây để ẩn đi khi win
    public AudioSource bgMusic; // Kéo nguồn phát nhạc nền vào đây (nếu có)

    private bool isGameEnded = false;

    private void Start()
    {
        // Đảm bảo màn hình Win bị ẩn khi mới bắt đầu game
        if (gameWinUI != null)
        {
            gameWinUI.SetActive(false);
        }
    }

    private void Update()
    {
        // Nếu game đã kết thúc (thắng hoặc thua) thì không kiểm tra nữa
        if (isGameEnded) return;

        // Kiểm tra xem số lượng địch còn sống đã về 0 chưa
        // (Lưu ý: Phải cập nhật biến LivingEnemyCount trong script EnemyHealth thì dòng này mới không báo lỗi)
        if (EnemyHealth.LivingEnemyCount <= 0)
        {
            OnGameWin();
        }
    }

    private void OnGameWin()
    {
        isGameEnded = true;

        // 1. Hiển thị bảng Game Win
        if (gameWinUI != null) gameWinUI.SetActive(true);

        // 2. Tắt nhạc nền (nếu có)
        if (bgMusic != null) bgMusic.Stop();

        // 3. Tắt máy bay người chơi cho đẹp khung hình
        if (player != null) player.SetActive(false);

        // 4. Đóng băng thời gian
        Time.timeScale = 0f;
    }

    // Hàm này dùng để gắn vào nút "Return to Main Menu" trên bảng Game Win
    public void ReturnToMainMenu()
    {
        Time.timeScale = 1f; // Bắt buộc phải rã đông thời gian trước khi chuyển Scene
        SceneManager.LoadScene("MainMenu"); // Đảm bảo gõ đúng tên Scene màn hình chính của bạn
    }
}