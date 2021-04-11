using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    // Start is called before the first frame update
    /*public void LoadGame()
    {
         SceneManager.LoadScene("Game");
    }*/
      public void Pause()
    {
       SceneManager.LoadScene(3);
       //Time.timeScale = 1f;
    }
    public void RestartGame()
    {
       SceneManager.LoadScene("Game");
       Time.timeScale = 1f;
    }
   
    public void RetourneMain () {
		Application.LoadLevel(0);
         Time.timeScale = 1f;
	}

    // Update is called once per frame
    public void Quit()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
   /* public void Restart()
    {
        SceneManager.LoadScene("Game");
    }*/
}
