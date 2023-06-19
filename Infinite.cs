using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Infinite : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float interval;
    public float range;

    private float timer = 0;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > interval)
        {
            GenerateObstacle();
            timer = 0;
        }

    }

    void GenerateObstacle()
    {
        float randomY = Random.Range(-range, range);
        float randomY2 = randomY + 15.3f;
        Vector3 position = new Vector3(transform.position.x, transform.position.y + randomY, transform.position.z);
        Vector3 position2 = new Vector3(transform.position.x, transform.position.y + randomY2, transform.position.z);
        GameObject obstacle = Instantiate(obstaclePrefab, position, Quaternion.identity);
        GameObject obstacle2 = Instantiate(obstaclePrefab, position2, Quaternion.identity);
        obstacle.GetComponent<Obstacle>().isClone = true;
        obstacle2.GetComponent<Obstacle>().isClone = true;
    }
}



