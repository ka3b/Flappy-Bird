using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject StartCanvas;
    public GameObject gameOverCanvas;
    public GameObject playTimerCanvas;
    private bool start = false;

    [SerializeField] 
    Text countText;

    void Start()
    {
        Time.timeScale = 0;
        gameOverCanvas.SetActive(false);
    }

    private void Update()
    {
    }

    public void Play()
    {
        Time.timeScale = 1.0f;
        StartCanvas.SetActive(false);
    }

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
    }

    public void CanvasMenu() 
        {
            if (start == false)
            {
            gameOverCanvas.SetActive(true);
            start = true;
            }
        } 

 
}
