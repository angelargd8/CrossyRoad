using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 offset = new Vector3(0, 8 ,-10 ); //distancia de la camera



    //corre hasta que se corre el update
    private void LateUpdate()
    {
        if ( target == null)
        {
            Debug.LogError("target is null");
            return;
        }

        transform.position = target.position + offset;

    }



}
