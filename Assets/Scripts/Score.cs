using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public int score = 0;
    public int highScore = 0;
    public float timer = 0f;
    public float timerRate = 5f;

    public Text scoreDispaly;

    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
    }

    void OnDestroy() {
        PlayerPrefs.SetInt("HighScore", highScore);
        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime * timerRate;

        if (timer >= 1f)
        {
            score++;
            scoreDispaly.text = "Score: " + score.ToString();
            timer = 0f;

            if (score > highScore) highScore = score;

        }
    }
}
