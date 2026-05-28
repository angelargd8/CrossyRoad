using UnityEngine;

public class WinCondition : MonoBehaviour
{
    [SerializeField] private GameObject winPanel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("ganador");
            Time.timeScale = 0f;
            winPanel.SetActive(true);

        }
    }
}
