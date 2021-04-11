using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aleatoire : MonoBehaviour
{
    public Rigidbody2D[] PrefabEnemi;
     public Vector2 LimitValeur;
     public float ValeurWait =0 ;
     public float ValeurSupWait;
     public float DebutWait;
     public float ValeurInWait;
     public bool stop;
     public int NbrEnemi;
     int RandEnemy;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait());
    }

    // Update is called once per frame
    void Update()
    {
        ValeurWait = Random.Range(ValeurInWait, ValeurSupWait);
        
    }
    IEnumerator Wait(){
        yield return new WaitForSeconds (DebutWait);
        while (!stop) {
        Rigidbody2D clone;
        Vector2 PositionEnemi = new Vector2 (Random.Range(-LimitValeur.x,LimitValeur.x), Random.Range(-LimitValeur.y,LimitValeur.y));
        RandEnemy = Random.Range(0, NbrEnemi);
        print(RandEnemy);
        Instantiate (PrefabEnemi[RandEnemy], PositionEnemi, Quaternion.identity);
       // print(PositionEnemi);
        yield return new WaitForSeconds (ValeurWait);
        }
    }
}
