using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartGame : MonoBehaviour
{
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
    public void RestartButton()
    {
        // Перезагрузить текущий активный сеанс (игру)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
