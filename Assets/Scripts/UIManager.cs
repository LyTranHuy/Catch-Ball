using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    public Text scoreText;
    public GameObject GameOverPanel;

    public void SetScoreText(string txt)
    {
        if (scoreText)
        {
            scoreText.text = txt;
        }
    }

    public void ShowGameoverPanel(bool isShow)
    {
        if (GameOverPanel)
        {
            GameOverPanel.SetActive(isShow);
        }
    }
}
