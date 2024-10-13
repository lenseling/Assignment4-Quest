using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private float timeRemaining = 30f;
    private bool gameActive = true;

    public TextMeshPro timerText;
    public TextMeshPro winText;

    private void Start()
    {
        winText.text = "";
        UpdateTimerText();
    }

    private void Update()
    {
        if (gameActive)
        {
            timeRemaining -= Time.deltaTime;
            UpdateTimerText();

            if (timeRemaining <= 0)
            {
                EndGame(false);
            }

            // Check if there are no remaining targets
            if (GameObject.FindGameObjectsWithTag("Target").Length == 0)
            {
                EndGame(true);
            }
        }
    }

    private void EndGame(bool win)
    {
        gameActive = false;
        timerText.text = "";
        winText.text = win ? "You Win!" : "Time's Up!";
    }

    private void UpdateTimerText()
    {
        timerText.text = $"Time: {Mathf.Max(0, Mathf.Round(timeRemaining))}s";
    }
}
