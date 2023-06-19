using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public bool isClone = false;

    private void Start()
    {
        if (isClone)
        {
            // set up the clone object
        }
    }

    void OnBecameInvisible()
    {
        if (isClone)
        {
            Destroy(gameObject);
        }
    }
}