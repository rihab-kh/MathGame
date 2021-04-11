/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Triger2 : MonoBehaviour
{
   public GameObject outputText1;
    //public GameObject inputValue;
    public GameObject PauseM1;
    public GameObject textResul1;
    public GameObject result11;
    public GameObject result21;
    public GameObject result31;
    public GameObject btres11,btres21, btres31;
    public GameObject teacher;
    private string Number_ = null;
    int Result;
    int Rand1, Rand2;
    float j = 1f;

    private void OnTriggerEnter2D(Collider2D collision1)
    {
        Pause();
    }
    
    private void Start(){
        PauseM1.SetActive(false);
        btres11.SetActive(false);
        btres21.SetActive(false);
        btres31.SetActive(false);
        textResul1.SetActive(false);
    }

    void Puzzel(int Result_)
    {
        if (Rand1 * Rand2 == Result_)
        {
            Debug.Log("Good job!!");
            textResul1.SetActive(true);
            textResul1.GetComponent<Text>().text = "Good job";
            Resume();
            StartCoroutine(Count(2f));

        }
        else
        {
            Debug.Log("Try again");
            textResul1.SetActive(true);
            textResul1.GetComponent<Text>().text = "Try again";
            Pause();
            StartCoroutine(Count(0.5f));

        }
    }*/

  /*  private void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            Number_ = inputValue.GetComponent<Text>().text;
            int.TryParse(Number_, out Result);
            Debug.Log(Result);
            Puzzel(Result);
        }
    }*/


  /*  void Resume()
    {
        PauseM1.SetActive(false);
        btres11.SetActive(false);
        btres21.SetActive(false);
        btres31.SetActive(false);
       // teacher.SetActive(false);
        Time.timeScale = 1f;
        gameObject.GetComponent<BoxCollider2D>().size = new Vector2(0f, 0f);

    }

    private void Pause()
    {
        
        PauseM1.SetActive(true);
        btres11.SetActive(true);
        btres21.SetActive(true);
        btres31.SetActive(true);
        Time.timeScale = 0f;
        Rand1 = (int)Random.Range(1f, 10f);
        Rand2 = (int)Random.Range(1f, 10f);
        int Res1 = Rand1 * Rand2;
        int Res2 = Rand1 * Rand2 - Random.Range(Rand1, Rand2);
        int Res3 = Rand1 * Rand2 + Random.Range(Rand1, Rand2);
        DisplayValue(Res1, Res2, Res3);
        outputText1.GetComponent<Text>().text = Rand1.ToString() + "*" + Rand2.ToString();

    }

    IEnumerator Count(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        textResul1.SetActive(false);
    }


    void DisplayValue(int R1, int R2, int R3)
    {
        Debug.Log(j);
        switch (j)
        {
            case 1f:
                result11.GetComponent<Text>().text = R1.ToString();
                result21.GetComponent<Text>().text = R3.ToString();
                result31.GetComponent<Text>().text = R2.ToString();
                break;
            case 2f:
                result11.GetComponent<Text>().text = R2.ToString();
                result21.GetComponent<Text>().text = R1.ToString();
                result31.GetComponent<Text>().text = R3.ToString();
                break;
            case 3f:
                result11.GetComponent<Text>().text = R3.ToString();
                result21.GetComponent<Text>().text = R1.ToString();
                result31.GetComponent<Text>().text = R2.ToString();
                break;
            case 4f:
                result11.GetComponent<Text>().text = R2.ToString();
                result21.GetComponent<Text>().text = R3.ToString();
                result31.GetComponent<Text>().text = R1.ToString();
                break;
            case 5f:
                result11.GetComponent<Text>().text = R3.ToString();
                result21.GetComponent<Text>().text = R1.ToString();
                result31.GetComponent<Text>().text = R2.ToString();
                break;
            default:
                result11.GetComponent<Text>().text = R1.ToString();
                result21.GetComponent<Text>().text = R2.ToString();
                result31.GetComponent<Text>().text = R3.ToString();
                break;


        }
        j++;
        // Vector2 Pos1 = result1.GetComponent<RectTransform>().position; 

    }
    public void validation1()
    {
        Number_ = result11.GetComponent<Text>().text;
        int.TryParse(Number_, out Result);
        Puzzel(Result);

    }
    public void validation2()
    {
        Number_ = result21.GetComponent<Text>().text;
        int.TryParse(Number_, out Result);
        Puzzel(Result);

    }
    public void validation3()
    {
        Number_ = result31.GetComponent<Text>().text;
        int.TryParse(Number_, out Result);
        Puzzel(Result);

    }
}
*/