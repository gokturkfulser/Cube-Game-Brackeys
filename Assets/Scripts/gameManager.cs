using UnityEngine;
using UnityEngine.SceneManagement;
public class gameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartTime = 1f;
    public GameObject completeLevelUI;
    public GameObject gameOverUI;
    public void LevelComplete()
    {
        if (gameHasEnded == false)
        {
            completeLevelUI.SetActive(true);
        }
    }
    public void gameOver()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            gameOverUI.SetActive(true);
            Invoke("restart", restartTime);
        }
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
