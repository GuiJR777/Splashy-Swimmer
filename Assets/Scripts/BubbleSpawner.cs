using UnityEngine;

public class BubbleSpawner : MonoBehaviour
{
    public GameObject bubblePrefab;

    public void spawnBubble()
    {
        GameObject bubbleInstance = Instantiate(
            bubblePrefab,
            transform.position + new Vector3(0.8f, 0.3f, 0f),
            transform.rotation,
            transform
        );

        float bubbleScale = Random.Range(0.05f, 0.1f);
        bubbleInstance.transform.localScale = new Vector3(
            bubbleScale,
            bubbleScale,
            bubbleScale
        );
    }
}