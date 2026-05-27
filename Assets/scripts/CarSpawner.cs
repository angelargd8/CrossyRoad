using UnityEngine;
using UnityEngine.Rendering;

public class CarSpawner : MonoBehaviour
{
    [SerializeField] private GameObject carPrefab;
    [SerializeField] private float spawnTime = 2f;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnCar), 0f, spawnTime);
    }

    private void SpawnCar()
    {
        Instantiate(carPrefab, transform.position, Quaternion.Euler(0f, 90f, 0f));
    }


}
