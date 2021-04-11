using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class deplaceNiv2 : MonoBehaviour
{
    Rigidbody2D r;
    public Animator anim;
    public GameObject textR;
     public GameObject panelR;
     public GameObject btR;
	bool Saut = false;
    public float crouch;
	float speed = 7;
	float score = 0;
	public float jump;
    bool IsFacingRight = true;
    public Triger5 Script;
    //public GameObject tableWL;
   // public GameObject textWL;
  
	// Use this for initialization

    void Start()
    {
    	r = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();

       // tableWL.SetActive(false);
       // textWL.SetActive(false);

       // startTime= Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            r.velocity = new Vector2(speed, r.velocity.y);
            anim.SetBool("isRunning", true);
            if (!IsFacingRight)
            {
                flip();
                IsFacingRight = true;
            }
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            r.velocity = new Vector2(-speed, r.velocity.y);
            anim.SetBool("isRunning", true);
            if (IsFacingRight)
            {
                flip();
                IsFacingRight = false;
            }

        }
        else
        {
            anim.SetBool("isRunning", false);
            r.velocity = new Vector2(0, r.velocity.y);
        }
		if (Input.GetKeyDown (KeyCode.Space)) {
			r.velocity = new Vector2(r.velocity.x, jump);
			anim.SetTrigger("isJumping");

		}
        
        if (Input.GetKey(KeyCode.DownArrow))
        {
            r.velocity = new Vector2(r.velocity.x, crouch);
			anim.SetTrigger("isCrouching");
        }
         // scoreText.text = score.ToString();

    }
      
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
    private void OnTriggerEnter2D(Collider2D collision)
    {   Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "TriggerAddSc")
        {
            Script.Pause();
        }
        if (collision.gameObject.name == "markq")
        {
            textR.SetActive(true);
            panelR.SetActive(true);
            btR.SetActive(true);
            textR.GetComponent<Text>().text = "Pour calculer une expression sans parenthèses, on effectue les divisions et les multiplications avant les additions et soustractions";
            Time.timeScale = 0f;  
        }
      
    }
    
    
}
