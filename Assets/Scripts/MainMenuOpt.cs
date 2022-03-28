using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuOpt : MonoBehaviour
{
    public static bool isLoading = false;
    public void NewGame()
    {
        SceneManager.LoadScene(2);
    }

    // Update is called once per frame
    public void Load()
    {
        isLoading = true;
        SceneManager.LoadScene(2);
    }
}
