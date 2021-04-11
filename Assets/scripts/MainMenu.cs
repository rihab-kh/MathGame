using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadGame()
    {
         SceneManager.LoadScene("Game");
    }
    public void RetourneMain () {
         Debug.Log("press!");
		Application.LoadLevel(0);
        //Time.timeScale = 1f;
	}
     public void Question() {
		Application.LoadLevel(2);
	}
    public void Resume()
    {
         SceneManager.LoadScene("Game");
        Time.timeScale = 1f;
       // gameObject.GetComponent<BoxCollider2D>().size = new Vector2(0f, 0f);

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
