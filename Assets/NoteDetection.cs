using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteDetection : MonoBehaviour
{
    public bool CanBePressed;
    public bool obtained;

    private void Awake()
    {
        obtained = false;
    }

    private void Update()
    {
       if(CanBePressed == true)
        {
            if (obtained == true)
            {
                NoteHit();
            }

        }
        
    


    }
    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D other)
    {
       
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (CanBePressed == false)
        {
            NoteMissed();
        }

       
    }
    
    public void NoteMissed()
    {
        Debug.Log("Note missed");
        obtained = false;
    }
    public void NoteHit()
    {
        Debug.Log("Note Hit");
    }
}
