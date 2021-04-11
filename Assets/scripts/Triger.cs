using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Triger : MonoBehaviour
{
    public GameObject outputText;
    public GameObject outputText2;
     public GameObject outputText3;
    //public GameObject inputValue;
    public GameObject PauseM;
    public GameObject PauseM2;
    public GameObject PauseM3;
    public GameObject textResul;
    public GameObject textResul2;
    public GameObject textResul3;
    public GameObject result1;
    public GameObject result2;
    public GameObject result3;
    public GameObject resultMult1;
    public GameObject resultMulti2;
    public GameObject resultMulti3;
    public GameObject resultMinus;
    public GameObject resultMinus2;
    public GameObject resultMinus3;
    public GameObject btres1,btres2, btres3;
    public GameObject btresMult1,btresMult2, btresMult3;
    public GameObject btresMin,btresMin2, btresMin3;
    public GameObject teacher;

   // public GameObject tableL;
    public GameObject textLose;
    public GameObject btRestart;
    public GameObject btHome;

    public Slider barVie;
    public Text healthText;
    static int health=20;
    private string Number_ = null;
    int Result, Result2, Result3;
    int Rand1, Rand2;
    float j = 1f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "TriggerAdd")
        {
            Pause();
        } 
        else if (collision.gameObject.name == "TriggerMult")
        {
            Pause2();
        } 
        else if (collision.gameObject.name == "TriggerMinus")
        {
            Pause3();
        } 
        
    }

    void Start(){
        PauseM.SetActive(false);
        btres1.SetActive(false);
        btres2.SetActive(false);
        btres3.SetActive(false);
        PauseM2.SetActive(false);
        btresMult1.SetActive(false);
        btresMult2.SetActive(false);
        btresMult3.SetActive(false);
        PauseM3.SetActive(false);
        btresMin.SetActive(false);
        btresMin2.SetActive(false);
        btresMin3.SetActive(false);
        textLose.SetActive(false);
        //textResul.SetActive(false);
        //textResul2.SetActive(false);
          healthText.text = barVie.value.ToString();
    }
    void Puzzel(int Result_)
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
            StartCoroutine(Count(0.5f));
            health = health-5;
            barVie.value=health;
            healthText.text = barVie.value.ToString();

            if ( health == 0){
               //  tableLose.SetActive(true);
                //PauseM.SetActive(false);
                btres1.SetActive(false);
                btres2.SetActive(false);
                btres3.SetActive(false);
                outputText.SetActive(false);
                textResul.SetActive(false);
                btHome.SetActive(true);
                btRestart.SetActive(true);
          
                Time.timeScale = 0f;
                Debug.Log("You Lose!!");
                textLose.SetActive(true);
                textLose.GetComponent<Text>().text = "You lose";
            }


        }
    }
      void Puzzel2(int Result_)
    {
        if (Rand1 * Rand2 == Result_)
        {
            Debug.Log("Good job!!");
            textResul2.SetActive(true);
            textResul2.GetComponent<Text>().text = "Good job";
            Resume();
            StartCoroutine(Count2(2f));

        }
        else
        {
            Debug.Log("Try again");
            textResul2.SetActive(true);
            textResul2.GetComponent<Text>().text = "Try again";
            Pause2();
            StartCoroutine(Count2(0.5f));

            health = health-5;
            barVie.value=health;
             healthText.text = barVie.value.ToString();

            if ( health == 0){
               //  tableLose.SetActive(true);
                //PauseM.SetActive(false);
                btresMult1.SetActive(false);
                btresMult2.SetActive(false);
                btresMult3.SetActive(false);
                outputText2.SetActive(false);
                textResul2.SetActive(false);
                btHome.SetActive(true);
                btRestart.SetActive(true);
                
          
                Time.timeScale = 0f;
                Debug.Log("You Lose!!");
                textLose.SetActive(true);
                textLose.GetComponent<Text>().text = "You lose";
            }



        }
    }

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

     void Puzzel3(int Result_)
    {
        if (Rand1 - Rand2 == Result_)
        {
            Debug.Log("Good job!!");
            textResul3.SetActive(true);
            textResul3.GetComponent<Text>().text = "Good job";
            Resume();
            StartCoroutine(Count3(2f));

        }
        else
        {
            Debug.Log("Try again");
            textResul3.SetActive(true);
            textResul3.GetComponent<Text>().text = "Try again";
            Pause3();
            StartCoroutine(Count3(0.5f));
            health = health-5;
            barVie.value=health;
            healthText.text = barVie.value.ToString();

            if ( health == 0){
               //  tableLose.SetActive(true);
                //PauseM.SetActive(false);
                btresMin.SetActive(false);
                btresMin2.SetActive(false);
                btresMin3.SetActive(false);
                outputText3.SetActive(false);
                textResul3.SetActive(false);
                btHome.SetActive(true);
                btRestart.SetActive(true);
          
                Time.timeScale = 0f;
                Debug.Log("You Lose!!");
                textLose.SetActive(true);
                textLose.GetComponent<Text>().text = "You lose";
            }


        }
    }



    void Resume()
    {
        PauseM.SetActive(false);
        btres1.SetActive(false);
        btres2.SetActive(false);
        btres3.SetActive(false);
        PauseM2.SetActive(false);
        btresMult1.SetActive(false);
        btresMult2.SetActive(false);
        btresMult3.SetActive(false);
        PauseM3.SetActive(false);
        btresMin.SetActive(false);
        btresMin2.SetActive(false);
        btresMin3.SetActive(false);
        //teacher.SetActive(false);
        Time.timeScale = 1f;
        gameObject.GetComponent<BoxCollider2D>().size = new Vector2(0f, 0f);

    }

    public void Pause()
    {
        
        PauseM.SetActive(true);
        btres1.SetActive(true);
        btres2.SetActive(true);
        btres3.SetActive(true);
        PauseM2.SetActive(false);
        btresMult1.SetActive(false);
        btresMult2.SetActive(false);
        btresMult3.SetActive(false);
        textResul.SetActive(true);
        Time.timeScale = 0f;
        Rand1 = (int)Random.Range(1f, 10f);
        Rand2 = (int)Random.Range(1f, 10f);
        int Res1 = Rand1 + Rand2;
        int Res2 = Rand1 + Rand2 + Random.Range(Rand1, Rand2);
        int Res3 = Rand1 + Rand2 - Random.Range(Rand1, Rand2);
        DisplayValue(Res1, Res2, Res3);
        outputText.GetComponent<Text>().text = Rand1.ToString() + "+" + Rand2.ToString() + " = ?";

    }

      public void Pause2()
    {
        
        PauseM2.SetActive(true);
        btresMult1.SetActive(true);
        btresMult2.SetActive(true);
        btresMult3.SetActive(true);
        PauseM.SetActive(false);
        btres1.SetActive(false);
        btres2.SetActive(false);
        btres3.SetActive(false);
        textResul2.SetActive(true);
        Time.timeScale = 0f;
        Rand1 = (int)Random.Range(1f, 10f);
        Rand2 = (int)Random.Range(1f, 10f);
        int Res1 = Rand1 * Rand2;
        int Res2 = Rand1 * Rand2 + Random.Range(Rand1, Rand2);
        int Res3 = Rand1 * Rand2 - Random.Range(Rand1, Rand2);
        DisplayValueMulti(Res1, Res2, Res3);
        outputText2.GetComponent<Text>().text = Rand1.ToString() + "x" + Rand2.ToString() + " = ?";

    }

    public void Pause3()
    {
        
        PauseM3.SetActive(true);
        btresMin.SetActive(true);
        btresMin2.SetActive(true);
        btresMin3.SetActive(true);
       /* PauseM.SetActive(false);
        btres1.SetActive(false);
        btres2.SetActive(false);
        btres3.SetActive(false);*/
        textResul3.SetActive(true);
        Time.timeScale = 0f;
        Rand1 = (int)Random.Range(10f, 50f);
        Rand2 = (int)Random.Range(1f, 10f);
        int Res1 = Rand1 - Rand2;
        int Res2 = Rand1 + Rand2 + Random.Range(Rand1, Rand2);
        int Res3 = Rand1 + Rand2 - Random.Range(Rand1, Rand2);
        DisplayValueMinus(Res1, Res2, Res3);
        outputText3.GetComponent<Text>().text = Rand1.ToString() + "-" + Rand2.ToString() + " = ?";

    }

    IEnumerator Count(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        textResul.SetActive(false);
    }
      IEnumerator Count2(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        textResul2.SetActive(false);
    }
    IEnumerator Count3(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        textResul3.SetActive(false);
    }


    void DisplayValue(int R1, int R2, int R3)
    {
        Debug.Log(j);
        switch (j)
        {
            case 1f:
                result1.GetComponent<Text>().text = R1.ToString();
                result2.GetComponent<Text>().text = R3.ToString();
                result3.GetComponent<Text>().text = R2.ToString();
                break;
            case 2f:
                result1.GetComponent<Text>().text = R2.ToString();
                result2.GetComponent<Text>().text = R1.ToString();
                result3.GetComponent<Text>().text = R3.ToString();
                break;
            case 3f:
                result1.GetComponent<Text>().text = R3.ToString();
                result2.GetComponent<Text>().text = R1.ToString();
                result3.GetComponent<Text>().text = R2.ToString();
                break;
            case 4f:
                result1.GetComponent<Text>().text = R2.ToString();
                result2.GetComponent<Text>().text = R3.ToString();
                result3.GetComponent<Text>().text = R1.ToString();
                break;
            case 5f:
                result1.GetComponent<Text>().text = R3.ToString();
                result2.GetComponent<Text>().text = R1.ToString();
                result3.GetComponent<Text>().text = R2.ToString();
                break;
            default:
                result1.GetComponent<Text>().text = R1.ToString();
                result2.GetComponent<Text>().text = R2.ToString();
                result3.GetComponent<Text>().text = R3.ToString();
                break;


        }
        j++;
        // Vector2 Pos1 = result1.GetComponent<RectTransform>().position; 

    }

    void DisplayValueMulti(int R1, int R2, int R3)
    {
        Debug.Log(j);
        switch (j)
        {
            case 1f:
                resultMult1.GetComponent<Text>().text = R1.ToString();
                resultMulti2.GetComponent<Text>().text = R3.ToString();
                resultMulti3.GetComponent<Text>().text = R2.ToString();
                break;
            case 2f:
                resultMult1.GetComponent<Text>().text = R2.ToString();
                resultMulti2.GetComponent<Text>().text = R1.ToString();
                resultMulti3.GetComponent<Text>().text = R3.ToString();
                break;
            case 3f:
                resultMult1.GetComponent<Text>().text = R3.ToString();
                resultMulti2.GetComponent<Text>().text = R1.ToString();
                resultMulti3.GetComponent<Text>().text = R2.ToString();
                break;
            case 4f:
                resultMult1.GetComponent<Text>().text = R2.ToString();
                resultMulti2.GetComponent<Text>().text = R3.ToString();
                resultMulti3.GetComponent<Text>().text = R1.ToString();
                break;
            case 5f:
                resultMult1.GetComponent<Text>().text = R3.ToString();
                resultMulti2.GetComponent<Text>().text = R1.ToString();
                resultMulti3.GetComponent<Text>().text = R2.ToString();
                break;
            default:
                resultMult1.GetComponent<Text>().text = R1.ToString();
                resultMulti2.GetComponent<Text>().text = R2.ToString();
                resultMulti3.GetComponent<Text>().text = R3.ToString();
                break;


        }
        j++;
        // Vector2 Pos1 = result1.GetComponent<RectTransform>().position; 

    }

     void DisplayValueMinus(int R1, int R2, int R3)
    {
        Debug.Log(j);
        switch (j)
        {
            case 1f:
                resultMinus.GetComponent<Text>().text = R1.ToString();
                resultMinus2.GetComponent<Text>().text = R3.ToString();
                resultMinus3.GetComponent<Text>().text = R2.ToString();
                break;
            case 2f:
                resultMinus.GetComponent<Text>().text = R2.ToString();
                resultMinus2.GetComponent<Text>().text = R1.ToString();
                resultMinus3.GetComponent<Text>().text = R3.ToString();
                break;
            case 3f:
                resultMinus.GetComponent<Text>().text = R3.ToString();
                resultMinus2.GetComponent<Text>().text = R1.ToString();
                resultMinus3.GetComponent<Text>().text = R2.ToString();
                break;
            case 4f:
                resultMinus.GetComponent<Text>().text = R2.ToString();
                resultMinus2.GetComponent<Text>().text = R3.ToString();
                resultMinus3.GetComponent<Text>().text = R1.ToString();
                break;
            case 5f:
                resultMinus.GetComponent<Text>().text = R3.ToString();
                resultMinus2.GetComponent<Text>().text = R1.ToString();
                resultMinus3.GetComponent<Text>().text = R2.ToString();
                break;
            default:
                resultMinus.GetComponent<Text>().text = R1.ToString();
                resultMinus2.GetComponent<Text>().text = R2.ToString();
                resultMinus3.GetComponent<Text>().text = R3.ToString();
                break;


        }
        j++;
        // Vector2 Pos1 = result1.GetComponent<RectTransform>().position; 

    }

    public void validation1()
    {
        Number_ = result1.GetComponent<Text>().text;
        int.TryParse(Number_, out Result);
        Puzzel(Result);

    }
    public void validation2()
    {
        Number_ = result2.GetComponent<Text>().text;
        int.TryParse(Number_, out Result);
        Puzzel(Result);

    }
    public void validation3()
    {
        Number_ = result3.GetComponent<Text>().text;
        int.TryParse(Number_, out Result);
        Puzzel(Result);

    }
     public void validation11()
    {
        Number_ = resultMult1.GetComponent<Text>().text;
        int.TryParse(Number_, out Result2);
        Puzzel2(Result2);

    }
    public void validation21()
    {
        Number_ = resultMulti2.GetComponent<Text>().text;
        int.TryParse(Number_, out Result2);
        Puzzel2(Result2);

    }
    public void validation31()
    {
        Number_ = resultMulti3.GetComponent<Text>().text;
        int.TryParse(Number_, out Result2);
        Puzzel2(Result2);

    }
    public void validationMinus1()
    {
        Number_ = resultMinus.GetComponent<Text>().text;
        int.TryParse(Number_, out Result3);
        Puzzel3(Result3);

    }
    public void validationMinus2()
    {
        Number_ = resultMinus2.GetComponent<Text>().text;
        int.TryParse(Number_, out Result3);
        Puzzel3(Result3);

    }
    public void validationMinus3()
    {
        Number_ = resultMinus3.GetComponent<Text>().text;
        int.TryParse(Number_, out Result3);
        Puzzel3(Result3);

    }
}
