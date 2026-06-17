using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelComplete : MonoBehaviour
{

    public  TextMeshProUGUI levelText;
    public void LoadNextLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
}
