using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DeplacementPerso : MonoBehaviour
{
    Rigidbody2D r;
    public Animator anim;
	bool Saut = false;
    public float crouch;
	float speed = 12;
	float score = 0;
	public float jump;
    bool IsFacingRight = true;
    public Text scoreText;
     public Text timerText;
     private float startTime;
    public GameObject tableWL;
    public GameObject textWL;
    public Triger Script, Script2, Script3;
	// Use this for initialization

    void Start()
    {
    	r = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();

        tableWL.SetActive(false);
        textWL.SetActive(false);

        startTime= Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - startTime;
        string min= ((int) t / 60).ToString();
        string sec= (t % 60).ToString("F2");
        timerText.text= min + ":" + sec;
		//mouvement
        if (Input.GetAxis("Horizontal") > 0)
        {
            r.velocity = new Vector2(speed, r.velocity.y);
            anim.SetBool("IsRunning", true);
            if (!IsFacingRight)
            {
                flip();
                IsFacingRight = true;
            }
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            r.velocity = new Vector2(-speed, r.velocity.y);
            anim.SetBool("IsRunning", true);
            if (IsFacingRight)
            {
                flip();
                IsFacingRight = false;
            }

        }
        else
        {
            anim.SetBool("IsRunning", false);
            r.velocity = new Vector2(0, r.velocity.y);
        }
		if (Input.GetKeyDown (KeyCode.Space)) {
			r.velocity = new Vector2(r.velocity.x, jump);
			anim.SetTrigger("IsJumping");

		}
        
        if (Input.GetKey(KeyCode.DownArrow))
        {
            r.velocity = new Vector2(r.velocity.x, crouch);
			anim.SetTrigger("crouch");
        }
          scoreText.text = score.ToString();

    }
      	//float MoveVertical = Input.GetAxis ("Vertical");
		/*float MoveHorizontal = Input.GetAxis ("Horizontal");
		print (MoveHorizontal);
		if (MoveHorizontal > 0f)
			anim.SetInteger ("direction",1);
		else if (MoveHorizontal < 0f) {
			anim.SetInteger ("direction", 3);
			print ("arriere");
		}
		else {
			anim.SetInteger ("direction",0);
		}
		//Vector2 MovePerso = new Vector2 (MoveHorizontal, MoveVertical);
		Vector2 MovePerso = new Vector2 (MoveHorizontal, 0);
		r.AddForce (MovePerso * speed);
		//r.velocity = MovePerso * speed;

		if (Input.GetKeyDown (KeyCode.Space) && Saut) {
			Sauter ();
			anim.SetInteger ("direction",2);

		}*/

		// score update 
      
    void flip()
    {
        Vector3 theScale = this.transform.localScale;
        theScale.x *= -1;
        this.transform.localScale = theScale;
    }
	void Sauter(){
		Vector2 SautPerso = new Vector2 (0, speed);
		//r.AddForce (SautPerso);
		r.velocity = SautPerso;

	}

	void OnCollisionEnter2D(Collision2D autreobj){
		if (autreobj.gameObject.tag == "table")
			Saut = true;
		if (autreobj.gameObject.tag == "Enemi")
			Destroy (autreobj.gameObject);
	}

	void OnCollisionExit2D(Collision2D autreobj){
		if (autreobj.gameObject.tag == "table")
			Saut = false;
	} 
   
	//detecting coins
    private void OnTriggerEnter2D(Collider2D collision)
    {   Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "TriggerAdd")
        {
            Script.Pause();
        }
        else if (collision.gameObject.name == "TriggerMult")
        {
            Script2.Pause2();
        }
         else if (collision.gameObject.name == "TriggerMinus")
        {
            Script3.Pause3();
        }
        
        if (collision.CompareTag("coin"))
        {
            score+=10;
            Destroy(collision.gameObject);
        /*  if (collision.CompareTag("end"))
        {
            tableWL.SetActive(true);
            Debug.Log("You Won!!");
            textWL.SetActive(true);
            textWL.GetComponent<Text>().text = "You Won";
        }*/
        }
      
    }
   

}


