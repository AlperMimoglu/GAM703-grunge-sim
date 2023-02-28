using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource Themusic;
    public BeatScroller beatScroller;
    public bool StartedPlaynig;

    public void Start()
    {
        if (beatScroller.hasStarted == false)
        {
            StartedPlaynig = true;
            Themusic.Play();

        }
    }
  
    // Update is called once per frame
    
}
