//using UnityEngine;

//public class PlayerMovement : MonoBehaviour
//{
//    public float moveSpeed = 5f; // Movement speed of the player

//    void Update()
//    {
//        // Get input from the keyboard for horizontal and vertical movement
//        float moveHorizontal = Input.GetAxis("Horizontal"); // Arrow keys for left and right movement
//        float moveVertical = Input.GetAxis("Vertical"); // Arrow keys for up and down movement

//        // Create a movement vector that moves the player on the X and Z axes
//        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

//        // Move the player in the specified direction with the given speed and delta time for frame-rate independence
//        transform.Translate(movement * moveSpeed * Time.deltaTime);
//    }
//}



using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // Movement speed
    public float rotationSmoothTime = 0.1f; // Rotation smoothing
    private float rotationVelocity; // Rotation velocity

    void Update()
    {
        // Get input
        float moveHorizontal = Input.GetAxis("Horizontal"); // Horizontal input
        float moveVertical = Input.GetAxis("Vertical"); // Vertical input

        // Debug print
        Debug.Log("Horizontal: " + moveHorizontal + ", Vertical: " + moveVertical); // Log input

        // Create direction
        Vector3 direction = new Vector3(moveHorizontal, 0.0f, moveVertical).normalized; // Direction vector

        // Check movement
        if (direction.magnitude >= 0.1f) // Movement check
        {
            // Calculate angle
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg; // Target angle

            // Smooth rotation
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref rotationVelocity, rotationSmoothTime); // Smooth angle
            transform.rotation = Quaternion.Euler(0, angle, 0); // Apply rotation

            // Move player
            transform.Translate(direction * speed * Time.deltaTime, Space.World); // Move transform
        }
    }
}
