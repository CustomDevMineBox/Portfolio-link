using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnded : MonoBehaviour
{
    public void CloseGame() {
        Debug.Log("Quit!");
        Application.Quit();
    }

    public void MainMenu() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }

    public void StartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
