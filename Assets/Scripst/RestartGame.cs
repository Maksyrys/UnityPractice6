using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    private PinOutput pinOutput;

    void Start()
    {
        pinOutput = FindObjectOfType<PinOutput>();
        if (pinOutput == null)
        {
            Debug.LogError("PinOutput component not found in the scene.");
            return;
        }

        pinOutput.PinNumberText();
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}