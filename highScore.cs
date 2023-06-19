using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class highScore : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI coinCollected;
    public static highScore instance;
    public int coin;

    void Awake()
    {
        instance = this;
    }

    public void addCoin()
    {
        coin++;
        coinCollected.text = coin.ToString();
    }
}