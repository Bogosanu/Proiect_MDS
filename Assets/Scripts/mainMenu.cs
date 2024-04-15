using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadSceneAsync(3);
    }

    public void selectShop()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void selectSettings()
    {
        SceneManager.LoadSceneAsync(2);
    }
}
