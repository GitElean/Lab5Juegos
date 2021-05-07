using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public Slider slider;
    public GameObject PauseMenu;
    bool pause = false;
    AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
            TogglePause();

        audio.volume = slider.value;
    }

    public void TogglePause()
    {

        pause = !pause;
        PauseMenu.SetActive(pause);

        Time.timeScale = pause ? 0.0f : 1.0f;
    }

    public void restarScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

    public void changeScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
