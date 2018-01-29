using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class GameOver : MonoBehaviour
{
    public Text healthText;
    public static int health = 3;
    public Text scoreText;
    public static float score = 0;
    public Text highScore;
    public int highestScore = int.Parse(System.IO.File.ReadAllText("HighScore.txt"));

    // Use this for initialization
    void Start()
    {
        highestScore = int.Parse(System.IO.File.ReadAllText("HighScore.txt"));
        score = 0;

    }

    // Update is called once per frame
    void Update()
    {
        UpdateScore();
        UpdateHighScore();
        UpdateHealth();
        score += Time.deltaTime;

        if (score > highestScore)
        {
            highestScore = (int)score;
            System.IO.File.WriteAllText("Highscore.txt", highestScore.ToString());
            UpdateHighScore();
        }
        if (health <= 0)
        {
            health = 3;
            string name = "TitleScreen";
            Application.LoadLevel(name);

        }

    }
    void UpdateScore()
    {
        scoreText.text = "Score: " + (int)score;
    }
    void UpdateHighScore()
    {
        highScore.text = "HighScore: " + (int)highestScore;
    }
    private void UpdateHealth()
    {
        healthText.text = "Health: " + (int)health;
    }
}
