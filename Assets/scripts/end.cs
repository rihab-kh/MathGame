using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class end : MonoBehaviour
{
    public GameObject tableWL;
    public GameObject textWL;
    public GameObject btRestart;
    public GameObject btHome;
     public GameObject theEnd;
    public Text scoreText;
    float score = 0;
  /*void OnCollisionEnter2D(Collision2D autreobj){
		if (autreobj.gameObject.tag == "end")
			Pause();
	}*/
      private void OnTriggerEnter2D(Collider2D collision)
    {
        theEnd.SetActive(true);
           tableWL.SetActive(true);
           btHome.SetActive(true);
           btRestart.SetActive(true);
           Time.timeScale = 0f;
            Debug.Log("You Won!!");
            textWL.SetActive(true);
            textWL.GetComponent<Text>().text = "You Won";
             //scoreText.text = "Score :" + score;
        
    }

    void Start(){
        Time.timeScale = 1f;
        tableWL.SetActive(false);
        textWL.SetActive(false);
        btHome.SetActive(false);
        btRestart.SetActive(false);
       
    }
}

  /*  private void Pause()
    {
        if (collision.CompareTag("end"))
         {
            score++;
            Destroy(collision.gameObject);
        }
        tableWL.SetActive(true);
         Time.timeScale = 0f;
            Debug.Log("You Won!!");
            textWL.SetActive(true);
            textWL.GetComponent<Text>().text = "You Won";
             scoreText.text = "Score :" + score;
    }*/


