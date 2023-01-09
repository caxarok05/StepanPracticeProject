using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public int score = 0;
    public static int highScore = 0;
    public static ScoreScript Instance;

    [SerializeField] private Text ScoreText;

    private void Awake()
    {
        Instance = this;
    }

    void Update()
    {
        ScoreText.text = "Score: " + score;
    }
}
