using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text score;

    void Update()
    {
        score.text = GameManager.Instance.score.ToString();
    }
}
