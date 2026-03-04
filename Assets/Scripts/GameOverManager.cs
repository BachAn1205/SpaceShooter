using UnityEngine;
using UnityEngine.SceneManagement; // Bắt buộc phải có dòng này để chuyển Scene

public class GameOverManager : MonoBehaviour
{
    // Hàm này sẽ được gọi khi bạn click vào nút
    public void ReturnToMainMenu()
    {
        // 1. Rã đông thời gian (đưa tốc độ game về lại bình thường)
        Time.timeScale = 1f;

        // 2. Load lại Scene có tên là "MainMenu"
        // (Lưu ý: Chữ "MainMenu" phải gõ chính xác 100% tên file Scene của bạn)
        SceneManager.LoadScene("MainMenu"); 
    }
}