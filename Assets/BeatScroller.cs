using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeatScroller : MonoBehaviour
{
    public float beatTempo;
    public bool hasStarted;
    public float CountDown = 0.5f;
    public Text CountDownText;
    private float secs;
    public AudioSource Themusic;

    // Start is called before the first frame update

    public void Start()
    {
        beatTempo = beatTempo / 60f; 
    }
    // Update is called once per frame
    void Update()
    {
        if (CountDown > 0 && hasStarted == false)
        {
            
            StartCoroutine(Wait());
        }
        else
        {
            hasStarted = true;
            transform.position -= new Vector3(0f, beatTempo * Time.deltaTime, 0f);
            
        }
    }
    IEnumerator Wait()
    {
        CountDown -= 1;
        UpdateTimer();
        yield return new WaitForSeconds(1);
        hasStarted = false;
    }
    void UpdateTimer()
    {
       // int min = Mathf.FloorToInt(CountDown / 60);
        int sec = Mathf.FloorToInt(CountDown % 60);
        CountDownText.GetComponent<UnityEngine.UI.Text>().text = sec.ToString("00");
        
    }
}
