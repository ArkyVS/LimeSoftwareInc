using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followthis : MonoBehaviour
{

    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

}
