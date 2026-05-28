using UnityEngine;
using UnityEngine.Rendering;

public class CarMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    [SerializeField] private int xMax = 40;


    private void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;

        if (transform.position.x > xMax)
        {
            Destroy(gameObject);
        }


    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.LoseGame();
            
        }
    }
}
