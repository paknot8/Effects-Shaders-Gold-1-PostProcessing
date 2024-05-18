using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float speed = 10f; // Movement speed

    void Update()
    {
        // Get input from the player
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement direction based on input
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * speed * Time.deltaTime;

        // Apply vertical movement
        if (Input.GetKey(KeyCode.Space)) // Move up
        {
            movement += Vector3.up * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.LeftControl)) // Move down
        {
            movement += Vector3.down * speed * Time.deltaTime;
        }

        // Move the camera
        transform.Translate(movement);
    }
}
