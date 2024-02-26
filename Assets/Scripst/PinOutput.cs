using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PinOutput : MonoBehaviour
{
    public TextMeshProUGUI _FirstPinText;
    public TextMeshProUGUI _SecondPinText;
    public TextMeshProUGUI _ThirdPinText;

    private PinNumbersScript number ;

    void Start()
    {
        number = GetComponent<PinNumbersScript>();
        if (number == null)
        {
            Debug.LogError("Ошибка");
            return;
        }
    }

    public void PinNumberText()
    {
            _FirstPinText.text = number.FirstPinNumber.ToString();
            _SecondPinText.text = number.SecondPinNumber.ToString();
            _ThirdPinText.text = number.ThirdPinNumber.ToString();
        
    }
}
