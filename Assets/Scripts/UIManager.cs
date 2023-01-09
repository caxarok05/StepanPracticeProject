using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text _highscoreText;

    private static string _highscoreKey = "HighscoreKey";

    private void Awake()
    {
        Time.timeScale = 1;
        ScoreScript.highScore = PlayerPrefs.GetInt(_highscoreKey);
        _highscoreText.text = "Max Score: " + ScoreScript.highScore;
    }
    public void EndGame()
    {
        Application.Quit();
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ChangeScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    public static void DisplayPanel(GameObject deathPanel)
    {
        deathPanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void ClosePanel(GameObject panel)
    {
        panel.SetActive(false);
    }
    public static void CalculateHighscore()
    {
        if (ScoreScript.highScore <= ScoreScript.Instance.score)
        {
            ScoreScript.highScore = ScoreScript.Instance.score;
        }
        PlayerPrefs.SetInt(_highscoreKey, ScoreScript.highScore);
    }
}
