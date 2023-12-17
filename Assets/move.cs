using UnityEngine;

public class move : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotationSpeed = 100f;
    void Update()
    {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            
            transform.Translate(Vector3.forward * verticalInput * moveSpeed * Time.deltaTime);
            transform.Rotate(Vector3.up * horizontalInput * rotationSpeed * Time.deltaTime);
    }  
}