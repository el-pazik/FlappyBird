using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private GameObject pipe_bottom;
    [SerializeField] private Transform PlayerPosition;
    [SerializeField] private Text maxScore;

    private Text scoreText;
    private float maxTime = 2;
    private float timer = -2;

    public Text ScoreText
    {
        get
        {
            return scoreText;
        }
    }

    private int _score = 0;

    public int Score
    {
        get
        {
            return _score;
        }
        set
        {
            _score = value;
            scoreText.text = $"{value}";
        }
    }

    void Start()
    {
        maxScore.text = $"{PlayerPrefs.GetInt("MaxScore", 0)}";
        scoreText = GetComponent<Text>();
    }

    
    void Update()
    {
        if (timer > maxTime)
        {
            Score += 1;
            timer = 0;
            /*if (Score > PlayerPrefs.GetInt("MaxScore", 0))
            {
                maxScore.text = $"{Score}";
            }*/

            Debug.Log("Score");
        }

        timer += Time.deltaTime;
    }

    public void ZeroCounter()
    {
        if (Score > PlayerPrefs.GetInt("MaxScore", 0))
        {
            PlayerPrefs.SetInt("MaxScore", Score);
            maxScore.text = $"{Score}";
        }
        Score = 0;
    }
}
