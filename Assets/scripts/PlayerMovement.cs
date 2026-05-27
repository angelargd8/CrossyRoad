using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //[SerializeField] private float speed = 5f;

    //private void Update()
    //{
    //    float horizontalInput = Input.GetAxis("Horizontal");
    //    float verticalInput = Input.GetAxis("Vertical");

    //    Vector3 direccion = new Vector3(horizontalInput, 0 ,verticalInput);
    //    transform.position += direccion * speed * Time.deltaTime;
    //}

    [SerializeField] private float stepSize = 1.0f;
    [SerializeField] private float rayDistance = 1f;

    
    private void Move(Vector3 direction)
    {

        if (canMove(direction))
            transform.position += direction * stepSize; //player new position
        
    }

    private bool canMove(Vector3 direction)
    {
        Ray ray = new Ray(transform.position, direction);

        if(Physics.Raycast(ray, rayDistance, ~0, QueryTriggerInteraction.Ignore))
        {
            return false;
        }                

        return true;
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            Move(Vector3.forward);

        }

        else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            Move(Vector3.back);

        }

        else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Move(Vector3.left);

        }
        else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            Move(Vector3.right);

        }
    }
}
