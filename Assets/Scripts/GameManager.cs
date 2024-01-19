using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public List<GameObject> obstacles;
    public List<GameObject> props;

    public float obstacleInterval = 2f;

    public float obstacleSpeed = 2f;

    public Vector2 obstacleYOffset = new Vector2(0.5f, 2f);

    public float obstacleXOffset = 20f;

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
        Debug.Log("Game Over! Score: " + score);
    }
}