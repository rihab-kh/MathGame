using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrigerSc2 : MonoBehaviour
{
    public GameObject outputText;
    public GameObject inputValue;
    public GameObject PauseM;
    public GameObject textResul;
    private string Number_ = null;
    int Result;
    int Rand1, Rand2;
    float j = 100f;

  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "TriggerAdd")
        {
            Pause();
        } 
    }

    void Start(){
        PauseM.SetActive(false);
        inputValue.SetActive(false);
        
    }

    void Puzzel( int Result_)
    {
        if (Rand1 + Rand2 == Result_)
        {
            Debug.Log("Good job!!");
            textResul.SetActive(true);
            textResul.GetComponent<Text>().text = "Good job";
            Resume();
            StartCoroutine(Count(2f));

        }
        else
        {
            Debug.Log("Try again");
            textResul.SetActive(true);
            textResul.GetComponent<Text>().text = "Try again";
            Pause();
            StartCoroutine(Count1(0.5f));

        }
      

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            Number_ = inputValue.GetComponent<Text>().text;
            int.TryParse(Number_, out Result);
            Debug.Log(Result);
            Puzzel(Result);
        }
    }


  void Resume()
    {
        PauseM.SetActive(false);
        Time.timeScale = 1f;
        gameObject.GetComponent<BoxCollider2D>().size = new Vector2(0f,0f); 
        
    }

    public void Pause()
    {
        PauseM.SetActive(true);
        textResul.SetActive(true);
        outputText.SetActive(true);
        inputValue.SetActive(true);
        Time.timeScale = 0f;
        Rand1 = (int)Random.Range(1f, 10f);
        Rand2 = (int)Random.Range(1f, 10f);
      //  Update();
        outputText.GetComponent<Text>().text = Rand1.ToString() + "+" + Rand2.ToString() + "=";
     

    }

    IEnumerator Count(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        textResul.SetActive(false);
    }

    IEnumerator Count1(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        textResul.SetActive(false);
    }
}
