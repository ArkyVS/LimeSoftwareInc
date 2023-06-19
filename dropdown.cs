using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class dropdown : MonoBehaviour
{

    public void handleInput(int val)
    {
        if (val == 0)
        {
            Debug.Log("This is phone number for ovo");
        }
        else if (val == 1)
        {
            Debug.Log("This is phone number for gopay");
        }
        else if (val == 2)
        {
            Debug.Log("This is phone number for dana");
        }
    }

    public void handleInputPrize(int val)
    {
        if (val == 0)
        {
            Debug.Log("Rp.100");
        }
        else if (val == 1)
        {
            Debug.Log("Rp.500");
        }
        else if (val == 2)
        {
            Debug.Log("Rp.1000");
        }
    }

    public void sentToServer()
    {
        Debug.Log("Sent to server");
        SceneManager.LoadScene("Setting");
    }
}
