using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public static bool isPaused = false;
    public bool pauseBtnclick;
    public GameObject pausePage;
    
    // Start is called before the first frame update
    void Start()
    {
        pausePage.SetActive(false);
        isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || pauseBtnclick)
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Stop();
            }
            pauseBtnclick = false;
        }
    }

    public void PauseBtn()
    {
        pauseBtnclick = true;
    }

    public void Resume()
    {
        pausePage.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    void Stop()
    {
        pausePage.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void Replay()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex));
    }

    public void Home()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("StartScene");
    }
}
