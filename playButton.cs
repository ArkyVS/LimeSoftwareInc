using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playButton : MonoBehaviour
{

    public Button myButton; // Reference to the button component

    void Start()
    {
        // Get a reference to the button component
        myButton = GetComponent<Button>();

        // Add an onclick listener to the button
        myButton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        // Do something when the button is clicked
        SceneManager.LoadScene("gameplayy");
    }

}
