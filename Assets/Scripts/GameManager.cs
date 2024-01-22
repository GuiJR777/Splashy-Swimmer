using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public GameObject GameOverScreen;

    public List<GameObject> obstacles;
    public List<GameObject> props;

    public float obstacleInterval = 2f;

    public float obstacleSpeed = 2f;

    public Vector2 obstacleYOffset = new Vector2(0.5f, 2f);

    public float obstacleXOffset = 20f;

    public bool gameIsOver = false;

    [HideInInspector]
    public float score = 0f;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void GameOver(float score)
    {
        GameOverScreen.SetActive(true);
        gameIsOver = true;
    }

    public void RestartGame()
    {
        score = 0f;
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }

    public void updateObstacleSpeed()
    {
        if (score % 10 == 0)
        {
            increaseObstacleSpeed();
        }
    }

    private void increaseObstacleSpeed()
    {
        obstacleSpeed += 0.5f;
    }
}