using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody physicBody;
    private BubbleSpawner bubbleSpawner;

    public GameObject sprite;

    public float swimForce = 1f;
    public float swimInterval = 0.5f;
    public bool canSwim = true;

    private float swimCooldown = 0f;


    void Start()
    {
        physicBody = GetComponent<Rigidbody>();
        bubbleSpawner = GetComponent<BubbleSpawner>();
    }

    void Update()
    {
        applyRotationOnSprite();
        updateCooldown();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Sensor"))
        {
            GameManager.Instance.score += 1f;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        GameManager.Instance.GameOver(GameManager.Instance.score);
    }


    private void applyRotationOnSprite()
    {
        sprite.transform.rotation = Quaternion.Euler(0f, 0f, physicBody.velocity.y * 3f);
    }

    private void updateCooldown()
    {
        canSwim = swimCooldown <= 0f;

        if (!canSwim)
        {
            swimCooldown -= Time.deltaTime;
        }
    }

    public void Swim(InputAction.CallbackContext context)
    {
        if (canSwim)
        {
            physicBody.velocity = Vector3.zero;
            physicBody.AddForce(Vector3.up * swimForce, ForceMode.Impulse);
            bubbleSpawner.spawnBubble();
            swimCooldown = swimInterval;
        }
    }
}
