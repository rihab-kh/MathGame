using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCartouche : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D other){
        if (other.gameObject.CompareTag("cartoucha")){
         Destroy (other.gameObject);
         Destroy (gameObject);
        }
    }
        
}
