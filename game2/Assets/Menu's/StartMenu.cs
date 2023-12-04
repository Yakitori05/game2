using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuotherlvl : MonoBehaviour
{
    public GameObject startMenu;
    public GameObject startPoint;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "Lvl1")
        {
            Time.timeScale = 0f;
            startMenu.SetActive(true);
            Cursor.visible = true;
        }
        else  
        {
            Time.timeScale = 1f;
            startMenu.SetActive(false);
            Cursor.visible = false;
        }
    }

    // Update is called once per frame
    void Update()
    {        
               
    }
    public void quit()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        Time.timeScale = 1f;
        startMenu.SetActive(false);
        Cursor.visible = false;
        Player.transform.position = startPoint.transform.position;
    }
}
