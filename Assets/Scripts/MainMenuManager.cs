using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuMangaer : MonoBehaviour
{
    public AudioSource audioSource;

    public void OnPlayButtonClicked()
    {
        audioSource.Play();
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }

    public void OnQuitButtonClicked()
    {
        audioSource.Play();
        Application.Quit();
    }

    public void onInstagramButtonClicked()
    {
        audioSource.Play();
        Application.OpenURL("https://www.instagram.com/ramirestech.games/");
    }
}
