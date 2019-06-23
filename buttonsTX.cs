using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class buttonsTX : MonoBehaviour
{

    public void Gamemenu()
    {
        SceneManager.LoadScene("gamemenu");
    }
    public void Controls()
    {
        SceneManager.LoadScene("controls");
    }

    public void Quitgame()
    {
        Application.Quit();
    }

    public void Playagain()
    {
        SceneManager.LoadScene("gamemenu");
    }

    public void Mainmenu()
    {
        SceneManager.LoadScene("playermenu");
    }

}
