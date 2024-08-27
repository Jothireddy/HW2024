using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // The target for the camera to follow (Doofus)
    public float smoothSpeed = 0.125f; // Smoothness of the camera movement
    public Vector3 offset; // Offset from the target position

    void LateUpdate()
    {
        if (target != null)
        {
            // Calculate the desired position based on the target's position and the offset
            Vector3 desiredPosition = target.position + offset;
            // Smoothly interpolate between the current position and the desired position
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            // Set the camera position
            transform.position = smoothedPosition;

            // Optionally, make the camera look at the target
            transform.LookAt(target);
        }
    }
}
