using UnityEngine;

public class PropsSpawner : MonoBehaviour
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
            spawnProp();
            coolDown = Random.Range(0f, 1f);
        }
    }

    private void spawnProp()
    {
        if (gameManager.gameIsOver){return;}

        GameObject obstacleToSpawn = gameManager.props[Random.Range(0, gameManager.props.Count)];
        float obstacleXOffset = gameManager.obstacleXOffset;
        float obstacleYOffset = -3.72f;
        float obstacleZOffset = Random.Range(0.27f, -1.24f);
        Vector3 obstaclePosition = new Vector3(obstacleXOffset, obstacleYOffset, obstacleZOffset);
        Quaternion obstacleRotation = obstacleToSpawn.transform.rotation;
        float obstacleScaleValue = Random.Range(1f, 2f);
        Vector3 obstacleScale = new Vector3(obstacleScaleValue, obstacleScaleValue, obstacleScaleValue);

        GameObject prop = Instantiate(
            obstacleToSpawn,
            obstaclePosition,
            obstacleRotation
        );

        prop.transform.localScale = obstacleScale;

    }
}