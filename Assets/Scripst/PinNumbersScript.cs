using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class PinNumbersScript : MonoBehaviour
{   

    public int FirstPinNumber;
    public int SecondPinNumber;
    public int ThirdPinNumber;
    private int drillCount = 0; 
    private int hammerCount = 0; 
    private int masterKeyCount = 0; 

    public TextMeshProUGUI totalClicksText; 
    private PinOutput pinOutput;


    void Start()
    {
        pinOutput = GetComponent<PinOutput>();
        if (pinOutput == null)
        {
            Debug.LogError("Ошибка");
            return;
        }
        pinOutput.PinNumberText();
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

        pinOutput.PinNumberText();
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

        pinOutput.PinNumberText();
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

        pinOutput.PinNumberText();
        masterKeyCount++;
        UpdateTotalClicks();
    }
    
    public void UpdateTotalClicks()
    {
        totalClicksText.text = (drillCount + hammerCount + masterKeyCount).ToString();
    }
}
