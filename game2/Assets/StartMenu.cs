using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
    public GameObject startMenu;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
        startMenu.SetActive(true);
        Cursor.visible = true;
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
    }
}
