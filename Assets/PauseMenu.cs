using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour {
        public GameObject pauseMenuUI;
        public GameObject pauseOptionsUI;
        public GameObject arletButtonUI;
        public static bool GamePaused = false;
    
void Start () 
    {
        pauseMenuUI.SetActive(false);
        pauseOptionsUI.SetActive(false);
        arletButtonUI.SetActive(false);
    }

        void Update () {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamePaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }   
    }

public void Resume() {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;
    }
public void Back() {
    Time.timeScale = 1f;
    pauseMenuUI.SetActive(false);
    pauseOptionsUI.SetActive(false);
    GamePaused = false;
}
public void PauseOptions() {
    Time.timeScale = 1f;
    pauseOptionsUI.SetActive(true);
    pauseMenuUI.SetActive(false);
    GamePaused = false;
    
}

public void Pause() {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GamePaused = true; 
    }
        public void LoadMenu()
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("Startmenu");
        }
        public void QuitGame()
        {
            Application.Quit();
        }
        public void RestartLevel()
        {
        SceneManager.LoadScene("local");
        }
        
    
}


