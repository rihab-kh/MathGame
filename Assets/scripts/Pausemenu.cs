using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausemenu : MonoBehaviour
{
    public GameObject pauseScreen;
    public GameObject pause;
    public GameObject resume;    
    public GameObject brestart;
    public GameObject bhome;
     public GameObject bson;
         public GameObject image;
    bool GamePaused;
    // Start is called before the first frame update
    void Start()
    {
       // GamePaused= false;
        pauseScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        /*if (GamePaused){
             Time.timeScale = 0f;
        }
        else  Time.timeScale = 1f;*/
    }
    public void Paused(){
        GamePaused = true;
        pauseScreen.SetActive(true);
        image.SetActive(true);
        resume.SetActive(true);
        brestart.SetActive(true);
        bson.SetActive(true);
        bhome.SetActive(true);
        pause.SetActive(false);
    }
     public void Resume(){
        GamePaused = false;
        pauseScreen.SetActive(false);
        resume.SetActive(false);
         brestart.SetActive(false);
        bson.SetActive(false);
        bhome.SetActive(false);
        pause.SetActive(true);
    }
    public void RetourneMain () {
		Application.LoadLevel(0);
         Time.timeScale = 1f;
	}
     public void RestartGame()
    {
       SceneManager.LoadScene("Game");
       Time.timeScale = 1f;
    }
}
