using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    [Header("Time Settings")]
    public float maxTime = 10f; // Maximum time allowed for the level
    public Text timerText; // Text object to display the timer

    //private float currentTime; 
    private bool isTimerRunning = false;

    public float currentTime;
    //public static event TimerEnded OnTimerEnded;

    void Start()
    {
        ResetTimer();
        StartTimer();
    }

    void Update()
    {
        if (isTimerRunning)
        {
            UpdateTimer();
        }
    }

    public void ResetTimer()
    {
        currentTime = maxTime;
        UpdateTimerUI();

    }

    public void StartTimer()
    {
        isTimerRunning = true;
      
    }

    public void StopTimer()
    {
        isTimerRunning = false;
    }

    void UpdateTimerUI()
    {
        if (timerText != null)
        {
            timerText.text = currentTime.ToString("F1") + "s";
        }
    }

    void UpdateTimer()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
            UpdateTimerUI();
        }
        else
        {
            currentTime = 0;
            isTimerRunning = false;
            UpdateTimerUI();
            //OnTimerEnd?.Invoke();
            Debug.Log("Time is up!");
        }
    }

}