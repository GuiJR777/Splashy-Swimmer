using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    private float coolDown = 0f;
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameManager.Instance;
    }

    void Update()
    {
        coolDown -= Time.deltaTime;

        if (coolDown <= 0f)
        {
            spawnObstacle();
            coolDown = GameManager.Instance.obstacleInterval;
        }
    }

    private void spawnObstacle()
    {
        GameObject obstacleToSpawn = gameManager.obstacles[Random.Range(0, gameManager.obstacles.Count)];
        float obstacleXOffset = gameManager.obstacleXOffset;
        float obstacleYOffset = Random.Range(gameManager.obstacleYOffset.x, gameManager.obstacleYOffset.y);
        Vector3 obstaclePosition = new Vector3(obstacleXOffset, obstacleYOffset, 0f);
        Quaternion obstacleRotation = obstacleToSpawn.transform.rotation;

        Instantiate(
            obstacleToSpawn,
            obstaclePosition,
            obstacleRotation
        );

    }
}