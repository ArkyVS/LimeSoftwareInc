using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class coinstore : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI coinInTotal;
    public static coinstore instance;
    private highScore hg;
    public int totalCoin;


    public void Awake()
    {
        hg = highScore.instance;
        instance = this;
        totalCoin = PlayerPrefs.GetInt("totalCoin", 0); // Load the highscore value from PlayerPrefs
        coinInTotal.text = totalCoin.ToString();
    }

    public void storeCoin()
    {
        totalCoin += hg.coin;
        PlayerPrefs.SetInt("totalCoin", totalCoin);
        coinInTotal.text = totalCoin.ToString();
        
    }

}