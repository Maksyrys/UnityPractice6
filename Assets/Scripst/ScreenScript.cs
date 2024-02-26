using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScreenScript : MonoBehaviour
{
    public TextMeshProUGUI _TimerText;
    public float TotalTime;
    private float currentTime;
    public GameObject LoseScreen;
    public GameObject WinScreen;


    private PinNumbersScript number ;

    void Start()
    {
        currentTime = TotalTime;
        number = GetComponent<PinNumbersScript>();
        if (number == null)
        {
            Debug.LogError("Ошибка");
            return;
        }
    }

    void Update()
    {
        currentTime -= Time.deltaTime;
        _TimerText.text = (Mathf.Round(currentTime)).ToString();
        if(currentTime <= 0f)
        {
            LoseScreen.SetActive(true);
            _TimerText.text = "0";
        }

        if(number.FirstPinNumber == 5 && number.SecondPinNumber == 5 && number.ThirdPinNumber == 5)
        {
            WinScreen.SetActive(true);
            _TimerText.text = "0";
        }
    }
}
