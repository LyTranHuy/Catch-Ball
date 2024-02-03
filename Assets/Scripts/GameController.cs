using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject ball;
    public float SpawnTime;
    float p_spawnTime;

    int p_score;
    bool p_isGameover;

    UIManager p_ui;

    // Start is called before the first frame update
    void Start()
    {
        p_spawnTime = 0;
        p_ui = FindAnyObjectByType<UIManager>();
        p_ui.SetScoreText("Score: " +  p_score);
    }

    // Update is called once per frame
    void Update()
    {
        p_spawnTime -= Time.deltaTime;

        if (p_isGameover)
        {
            p_spawnTime = 0;
            p_ui.ShowGameoverPanel(true);
            return;
        }

        if (p_spawnTime <= 0)
        {
            SpawnBall();

            p_spawnTime = SpawnTime;
        }
    }

    public void SpawnBall()
    {
        Vector2 spawnPos = new Vector2(Random.Range(-10, 10), 6);

        if (ball)
        {
            Instantiate(ball, spawnPos, Quaternion.identity);
        }
    }

    public void Replay()
    {
        p_score = 0;
        p_isGameover = false;
        p_ui.SetScoreText("Score: " +  p_score);
        p_ui.ShowGameoverPanel(false);
    }

    public void SetScore(int value)
    {
        p_score = value;
    }

    public int GetScore()
    {
        return p_score;
    }

    public void PlusScore()
    {
        p_score++;
        p_ui.SetScoreText("Score: " +  p_score);
    }

    public bool IsGameover()
    {
        return p_isGameover;
    }

    public void SetPlayerState(bool state)
    {
        p_isGameover = state;
    }
}
