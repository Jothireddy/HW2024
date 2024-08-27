using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController Instance { get; private set; }
    public UIManager uiManager;
    private int score;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Optional: persists across scenes
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        uiManager.ShowStartScreen();
    }

    public void StartGame()
    {
        score = 0;
        uiManager.UpdateScore(score);
        uiManager.ShowStartScreen();
        // Additional game start logic here, e.g., enable player controls
    }

    public void RestartGame()
    {
        score = 0;
        uiManager.UpdateScore(score);
        uiManager.ShowStartScreen();
        // Restart game logic here
    }

    public void GameOver()
    {
        uiManager.ShowEndScreen(score);
    }

    public void IncrementScore()
    {
        score++;
        uiManager.UpdateScore(score);
    }
}

