using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartGame : MonoBehaviour
{
    public void RestartButton()
    {
        // Перезагрузить текущий активный сеанс (игру)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
