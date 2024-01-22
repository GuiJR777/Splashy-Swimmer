using UnityEngine;

public class TemporaryMSG : MonoBehaviour
{
    public float timeInScreen = 3.0f;

    void Start()
    {
        Destroy(this.gameObject, timeInScreen);
    }
}