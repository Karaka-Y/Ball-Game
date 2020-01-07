using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControle : MonoBehaviour {
    public void PlayPressed()
    {
        SceneManager.LoadScene("Level1");
    }
    public void ExitPressed()
    {
        Application.Quit();
        Debug.Log("Exit pressed!");
    }
    public void ExitGamePressed()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Load2Pressed()
    {
        SceneManager.LoadScene("Level2");
    }
}
