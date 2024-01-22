using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private float obstacleXMaxOffset;

    void Start()
    {
        obstacleXMaxOffset = GameManager.Instance.obstacleXOffset * -1f;
    }

    void FixedUpdate()
    {
        if (GameManager.Instance.gameIsOver){return;}

        transform.Translate(Vector3.left * GameManager.Instance.obstacleSpeed * Time.fixedDeltaTime);

        if (transform.position.x <= obstacleXMaxOffset)
        {
            Destroy(this.gameObject);
        }
    }

}