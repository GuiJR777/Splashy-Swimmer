using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScreenManager : MonoBehaviour
{

    public Text scoreText;

    public AudioSource audioSource;

    void Start()
    {
        scoreText.text = "Score: " + GameManager.Instance.score.ToString("0");
    }

    public void OnRestartButtonClicked()
    {
        audioSource.Play();
        GameManager.Instance.RestartGame();
    }

    public void OnMainMenuButtonClicked()
    {
        audioSource.Play();
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }
}
