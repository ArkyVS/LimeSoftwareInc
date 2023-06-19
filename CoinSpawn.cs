using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawn : MonoBehaviour
{
    public GameObject coins;
    public float interval;
    public float range;

    private float times = 0;

    void Update()
    {
        times += Time.deltaTime;

        if (times > interval)
        {
            GenerateCoin();
            times = 0;
        }
    }

    void GenerateCoin()
    {
        float randomY = Random.Range(-range, range);
        Vector3 position = new Vector3(transform.position.x, transform.position.y + randomY, transform.position.z);
        GameObject coin = Instantiate(coins, position, Quaternion.identity);   
        coin.GetComponent<Coin>().isClone = true;
    }
}



