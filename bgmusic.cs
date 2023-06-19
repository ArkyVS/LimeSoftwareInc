using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgmusic : MonoBehaviour
{
    void awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
