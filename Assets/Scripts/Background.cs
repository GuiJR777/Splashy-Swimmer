using UnityEngine;

public class Background : MonoBehaviour
{
    void FixedUpdate()
    {
        if (GameManager.Instance.gameIsOver){return;}

        transform.Translate(Vector3.left * -1.0f * Time.fixedDeltaTime);

        if (transform.position.x <= -83.8f)
        {
            transform.position = new Vector3(83.7f, transform.position.y, transform.position.z);
        }

    }
}