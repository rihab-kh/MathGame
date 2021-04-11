using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiate : MonoBehaviour
{
    public Rigidbody2D Capsule;
    public Transform filsNavette;
    Rigidbody2D clone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.Space)){
            clone=Instantiate(Capsule, new Vector2(filsNavette.position.x, filsNavette.position.y),filsNavette.rotation) as Rigidbody2D;
            clone.AddForce( new Vector2(3000,0));
            Destroy(clone.gameObject,10);
        }
    }
}
