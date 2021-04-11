using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using System;

public class Triger5 : MonoBehaviour
{
    public GameObject outputText;
    public GameObject inputValue;
    public GameObject PauseM;
    public GameObject textResul;
    //public Question currentQuestion;
    // public GameObject FieldInput;
    private string Number_ = null;
    int Result;
    int Rand1, Rand2, Rand3, Rand4;
    int nb;
    float j = 100f;

  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "TriggerAdd")
        {
            Pause();
        } 
    }

    /*void Start(){
        PauseM.SetActive(false);
        inputValue.SetActive(false);
        
    }*/

    void Puzzel( int Result_)
    {
        if ((Rand2 * Rand3) + Rand1 - Rand4 == Result_)
        {
            Debug.Log("Good job!!");
            textResul.SetActive(true);
            textResul.GetComponent<Text>().text = "Good job";
            Pause();
            Resume();
            StartCoroutine(Count(2f));

        }
        else
        {
            Debug.Log("Try again");
            textResul.SetActive(true);
            textResul.GetComponent<Text>().text = "Try again";
            Pause();
            StartCoroutine(Count(0.3f));

        }
      

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
             Debug.Log("Return key was pressed.");
            Number_ = inputValue.GetComponent<Text>().text;
            int.TryParse(Number_, out Result);
            Debug.Log(Result);
            Puzzel(Result);
        }
    }


  void Resume()
    {
        PauseM.SetActive(false);
        //textResul.SetActive(false);
        outputText.SetActive(false);
        inputValue.SetActive(false);
        Time.timeScale = 1f;
        gameObject.GetComponent<BoxCollider2D>().size = new Vector2(0f,0f); 
        
    }

    public void Pause()
    {
        PauseM.SetActive(true);
      //  textResul.SetActive(false);
        outputText.SetActive(true);
        inputValue.SetActive(true);
      //  FieldInput.SetActive(true);
        Time.timeScale = 0f;  
        Rand1 = (int)Random.Range(1f, 10f);
        Rand2 = (int)Random.Range(1f, 10f);
        Rand3 = (int)Random.Range(1f, 10f);
        Rand4 = (int)Random.Range(1f, 10f);
       //Update();
       //DisplayValue(outputText.GetComponent<Text>().text);
        outputText.GetComponent<Text>().text = Rand1.ToString() + "+" + Rand2.ToString() + "*" +
        Rand3.ToString() + "-" + Rand4.ToString() + "=";
        
    }
     public void Pause2()
    {
        PauseM.SetActive(true);
      //  textResul.SetActive(false);
        outputText.SetActive(true);
        inputValue.SetActive(true);
      //  FieldInput.SetActive(true);
        Time.timeScale = 0f;
      //  DisplayValue(outputText.GetComponent<Text>().text);
        outputText.GetComponent<Text>().text = Rand1.ToString() + "+" + Rand2.ToString() + "*" +
        Rand3.ToString() + "-" + Rand4.ToString() + "=";
       //Update();
       // outputText.GetComponent<Text>().text = Rand1.ToString() + "+" + Rand2.ToString() + "=";

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
    /*void DisplayValue(string R1)
    {
        Debug.Log(j);
        switch (j)
        {
            case 1f:
            outputText.GetComponent<Text>().text = Rand1.ToString() + "+" + Rand2.ToString() + "*" +
        Rand3.ToString() + "-" + Rand4.ToString() + "=";
                break;
            case 2f:
                outputText.GetComponent<Text>().text = Rand1.ToString() + "+" + Rand2.ToString() + "*" +
        Rand3.ToString() + "=";
                break;
            default:
               outputText.GetComponent<Text>().text = Rand2.ToString() + "*" +
        Rand3.ToString() + "-" + Rand4.ToString() + "=";
                break;
        }
        j++;
        // Vector2 Pos1 = result1.GetComponent<RectTransform>().position; 
    }*/
}
