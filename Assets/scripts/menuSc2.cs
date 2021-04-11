using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuSc2 : MonoBehaviour
{
    public GameObject pauseScreen;
    //public GameObject pause;
    public GameObject resume;    
   // public GameObject brestart;
    //public GameObject bhome;
     //public GameObject bson;
    //public GameObject image;
    bool GamePaused;
     public void LoadGame()
    {
         SceneManager.LoadScene("sc2");
    }
    public void RetourneMain () {
         Debug.Log("press!");
		Application.LoadLevel(0);
        //Time.timeScale = 1f;
	}
     public void Question() {
		Application.LoadLevel(2);
	}
    /*public void Resume()
    {
         SceneManager.LoadScene("sc2");
        Time.timeScale = 1f;
       // gameObject.GetComponent<BoxCollider2D>().size = new Vector2(0f, 0f);

    }*/
    public void Resume(){
        GamePaused = false;
        pauseScreen.SetActive(false);
        resume.SetActive(false);
         Time.timeScale = 1f;
    }

    // Update is called once per frame
    public void Quit()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
