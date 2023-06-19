using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wallet : MonoBehaviour
{
    public float speed = 2;
    public float force = 300;
    private highScore highScoreInstance;
    private coinstore cs;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
        highScoreInstance = highScore.instance; // Get the instance of the highScore class
        cs = coinstore.instance;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
        }
        else if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        // Restart
        SceneManager.LoadScene("menu");
        cs.Awake();
        cs.storeCoin();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        //coin
        if (collision?.tag == "Coin")
        {
            highScoreInstance.addCoin();
        }
    }

}