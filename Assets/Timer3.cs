using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer3 : MonoBehaviour
{
    //[SerializeField] destroy NewMethod;
   // public destroy destroy;
   // public Lova lova;

    [Header("Component")]
    public TextMeshProUGUI timerText;
    [Header("Timer Sttings")]
    public float currentTime;

    public bool countDown;

    [Header("LimitSettings")]
    public bool hasLimit;
    public float timerLimit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = countDown ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;
        timerText.text = currentTime.ToString("0.0");
//Time.timeScale = 0;

        if(hasLimit && ((countDown && currentTime <= timerLimit) || (!countDown && currentTime >= timerLimit)))
        {
            currentTime = timerLimit;
            SetTimerText();
            //destroy.NewMethod();
            //Debug.LogFormat("Mano KMI ");
			//destroy.SetTimerText();
			
	

        }

    }

    private void SetTimerText()
    {
        timerText.text = currentTime.ToString();
        Debug.LogFormat("Mano KMI ");
        //destroy.NewMethod();
		
        //Lova.NewMethod();
    }

}
