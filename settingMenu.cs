using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class settingMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void muteToggle(bool muted)
    {
        if (muted)
        {
            AudioListener.volume = 0;
        }
        else
        {
            AudioListener.volume = 1;
        }
    }

    // Update is called once per frame
    public void redeem()
    {
        // Do something when the button is clicked
        SceneManager.LoadScene("redeem");
    }

    public void quitGames()
    {
        Debug.Log("quitgame");
        Application.Quit();
    }

    public void backToMenu()
    {
        SceneManager.LoadScene("menu");
    }
}
