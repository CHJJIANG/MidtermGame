using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timer : MonoBehaviour
{
    [Header("Component")]
    public TextMeshProUGUI timerText;

    [Header("Timer Settings")]
    public float currentTime;

    public enemyManager enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

            currentTime += Time.deltaTime;
            SetTimerText();


    }

    private void SetTimerText()
    {
        timerText.text = currentTime.ToString("0.00");
    }
}
