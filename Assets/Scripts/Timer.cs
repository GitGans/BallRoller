using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour{
    private int sec = 0;
    private int min = 0;
    private Text timerText;
    private Text resultText;

    void Start(){
        timerText = GameObject.Find("Time").GetComponent<Text>();
        resultText = GameObject.Find("Score").GetComponent<Text>();
        StartCoroutine(TimeFlow());
    }
    IEnumerator TimeFlow(){
        while ((resultText.text != "You loose") & (resultText.text != "You win")){
            if(sec == 59){
                min++;
                sec = -1;
            }
            sec++;
            timerText.text = "Time: " + min.ToString("D2") + ":" + sec.ToString("D2");
            yield return new WaitForSeconds(1);
        }
    }
}
