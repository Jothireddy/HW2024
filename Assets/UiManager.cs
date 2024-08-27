using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI startText;
    public TextMeshProUGUI endText;
    public TextMeshProUGUI scoreText;
    public GameObject startButton;
    public GameObject retryButton;

    private void Start()
    {
        ShowStartScreen();
    }

    public void ShowStartScreen()
    {
        startText.gameObject.SetActive(true);
        startButton.SetActive(true);
        endText.gameObject.SetActive(false);
        retryButton.SetActive(false);
        scoreText.gameObject.SetActive(false);
    }

    public void ShowEndScreen(int finalScore)
    {
        startText.gameObject.SetActive(false);
        startButton.SetActive(false);
        endText.gameObject.SetActive(true);
        retryButton.SetActive(true);
        scoreText.gameObject.SetActive(false);
        endText.text = $"Game Over! Your Score: {finalScore}";
    }

    public void UpdateScore(int newScore)
    {
        if (scoreText != null)
        {
            scoreText.text = $"Score: {newScore}";
        }
    }

    public void OnStartButtonClicked()
    {
        GameController.Instance.StartGame();
    }

    public void OnRetryButtonClicked()
    {
        GameController.Instance.RestartGame();
    }
}
