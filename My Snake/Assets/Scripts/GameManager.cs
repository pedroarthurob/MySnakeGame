using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI highScoreText;
    [SerializeField] private TextMeshProUGUI currentScoreText;
    [SerializeField] private Snake snake;

    private void Update()
    {
        updateHighScore(PlayerPrefs.GetInt("HighScore"));
        updateCurrentScoreText(snake.getScore()-1);
    }
    public void updateHighScore(int newHighScore)
    {
        highScoreText.text = $"High Score: {newHighScore}";
    }

    public void updateCurrentScoreText(int newScoreText) 
    {
        currentScoreText.text = $"Current Score: {newScoreText}";
    }
}
