using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] private GameObject losePanel;


    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
            return;
        }
    }

    public void RestartGame()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // restart the actual scene

    }


    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoseGame()
    {
        Debug.Log("El jugador ha sido atropellado");
        
        losePanel.SetActive(true);
        Time.timeScale = 0f;
    }

}
