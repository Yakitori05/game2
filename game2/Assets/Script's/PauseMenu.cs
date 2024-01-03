using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject startMenu;
    public GameObject pauseMenu;
    public GameObject mainMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!pauseMenu.activeSelf) 
            { 
                Time.timeScale = 0f;
                pauseMenu.SetActive(true);
                Cursor.visible = true;
            }
            else
            {
                Time.timeScale = 1f;
                pauseMenu.SetActive(false);
                Cursor.visible = false;
            }
        }
    }
    public void quit()
    {
        if (SceneManager.GetActiveScene().name == "Lvl1")
        {
            Time.timeScale = 0f;
            startMenu.SetActive(true);
            Cursor.visible = true;
            pauseMenu.SetActive(false);
        }
        else
        {
            SceneManager.LoadScene("Lvl1");
            Time.timeScale = 0f;
            startMenu.SetActive(true);
            Cursor.visible = true;
            pauseMenu.SetActive(false);
        }        
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        Cursor.visible = false;
    }

    public void MaineMenu()
    {
        Time.timeScale = 0f;
        mainMenu.SetActive(true);
        Cursor.visible = true;
        pauseMenu.SetActive(false);        
    }
}
