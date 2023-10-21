using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagerMenuScrene : MonoBehaviour
{

    public void PlayButton()
    {
        SceneManager.LoadScene(1);
    }
    public void MenuScane()
    {
        SceneManager.LoadScene(0);
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}
