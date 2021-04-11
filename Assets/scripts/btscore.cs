using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btscore : MonoBehaviour
{
    float offset;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        offset = this.transform.position.x-player.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x + offset, 0, -1);
    }
}
