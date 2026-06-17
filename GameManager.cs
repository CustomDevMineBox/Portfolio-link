using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool GameHasBeenOver = false;
    public float delayRestart = 1f;
    private Score scoreText;
    public GameObject completeLevel;

    

    public void GameOver() {
        if (GameHasBeenOver == false) {
            GameHasBeenOver = true;
            Invoke("Restart", delayRestart);
        }
    }
    void Restart() {
        SceneManager.LoadScene("SampleScene");
    }

    public void CompleteLevel() {
        completeLevel.SetActive(true);
    }
}
