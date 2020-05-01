using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject PauseMenuUI;

    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused) 
            {
                Resume();
            } else {
                Pause();
            }
        }
    }

    public void Resume() {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause() {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        
    }

    public void Reiniciar() {
        GameIsPaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("Game");
        int y = SceneManager.GetActiveScene().buildIndex;
        SceneManager.UnloadSceneAsync(y);
    }

    public void abrirMenu(){
        SceneManager.LoadScene("MainMenu");
        int y = SceneManager.GetActiveScene().buildIndex;
        SceneManager.UnloadSceneAsync(y);
    }

    public void fecharJogo(){
        Application.Quit();
    }

}