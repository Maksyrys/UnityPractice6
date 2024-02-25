using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class PinNumbersScript : MonoBehaviour
{   
    public TextMeshProUGUI _FirstPinText;
    public TextMeshProUGUI _SecondPinText;
    public TextMeshProUGUI _ThirdPinText;
    public int FirstPinNumber;
    public int SecondPinNumber;
    public int ThirdPinNumber;
    public GameObject WinScreen;
    public TextMeshProUGUI _TimerText;
    public float TotalTime;
    private float currentTime;

    private int drillCount = 0; 
    private int hammerCount = 0; 
    private int masterKeyCount = 0; 

    public TextMeshProUGUI totalClicksText; 

    public GameObject LoseScreen;

    void Start()
    {
        PinNumberText();
        currentTime = TotalTime;
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

        if(FirstPinNumber == 5 & SecondPinNumber == 5 & ThirdPinNumber == 5)
        {
            WinScreen.SetActive(true);
            _TimerText.text = "0";
        }
    }


    private void PinNumberText()
    {
        _FirstPinText.text = FirstPinNumber.ToString();
        _SecondPinText.text = SecondPinNumber.ToString();
        _ThirdPinText.text = ThirdPinNumber.ToString();
    }


    public void hackingDrill()
    {
        if (FirstPinNumber < 10)
        {
            FirstPinNumber++;
            SecondPinNumber--;
        }
        else if (SecondPinNumber > 0)
        {
            SecondPinNumber--;
        }
        else
        {
            SecondPinNumber = 0;
        }

        PinNumberText();
        drillCount++;
        UpdateTotalClicks();
    }

   public void hackingHammer()
    {
        if (FirstPinNumber > 0)
        {
            FirstPinNumber--;
        }

        if (SecondPinNumber < 9)
        {
            SecondPinNumber += 2;
        }

        if (ThirdPinNumber > 0)
        {
            ThirdPinNumber--;
        }

        PinNumberText();
        hammerCount++;
        UpdateTotalClicks();
    }

    public void hackingMasterKey()
    {
        if (FirstPinNumber > 0)
        {
            FirstPinNumber--;
        }

        if (SecondPinNumber < 10)
        {
            SecondPinNumber++;
        }

        if (ThirdPinNumber < 10)
        {
            ThirdPinNumber++;
        }

        PinNumberText();
        masterKeyCount++;
        UpdateTotalClicks();
    }
    
    public void UpdateTotalClicks()
    {
        totalClicksText.text = (drillCount + hammerCount + masterKeyCount).ToString();
    }
}
