using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text TimerText;
    
	private float SecondsCount;
	private int MinuteCount;
	private int HourCount;
    private int DayCount;

    void Start()
    {
        DayCount = 1;
        HourCount = 6;
    }

    void Update()
    {
        UpdateTimerUI();
    }

    // Call this on update
    public void UpdateTimerUI()
    {
		//set timer UI
		SecondsCount += Time.deltaTime * 2;
		TimerText.text = HourCount +":00";
		
        if(SecondsCount >= 60)
        {
			MinuteCount++;
			SecondsCount = 0;
		}
        else if(MinuteCount >= 60)
        {
			HourCount++;
			MinuteCount = 0;
		}
        else if(HourCount >= 20)
        {
            DayCount++;
        }
	}
}
