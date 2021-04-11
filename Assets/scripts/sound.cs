using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    private bool isMuted;
    // Start is called before the first frame update
    void Start()
    {
        //isMuted = PlayerPrefs.GetInt("Muted") ==1;
        AudioListener.pause = isMuted;
        isMuted=false;
    }

    public void MutePressed()
    {
        isMuted = !isMuted;
        AudioListener.pause = isMuted;
        // AudioListener.pause = isMuted;
      //  PlayerPrefs.setInt("Muted", isMuted ? 1: 0);
    }

    
}
