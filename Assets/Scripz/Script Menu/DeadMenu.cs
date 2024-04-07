using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadMenu : MonoBehaviour
{
    public GameObject gameOverUI;
    public static bool Paused = false;
    public GameObject PauseMenuCanvas;
    // Start is called before the first frame update
    void Start()
    {
         Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gameOver()
    {
        gameOverUI.SetActive(true); 
        Time.timeScale = 0f;  
    }

    public void TryAgain()
    {
        SceneManager.LoadScene("Boss_Tuto");
        Time.timeScale = 1f;
    }

    public void Return()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }


}
