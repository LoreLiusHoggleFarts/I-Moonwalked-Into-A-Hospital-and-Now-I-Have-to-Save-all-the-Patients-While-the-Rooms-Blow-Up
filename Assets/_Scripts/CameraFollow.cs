using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float smoothness = .0125f;
    public float minX, maxX, minY, maxY;
    public Vector3 offset;

    void LateUpdate()
    {
        if (player == null) return;
        
        Vector3 desiredPosition = player.position + offset;
        desiredPosition.z = transform.position.z;
        
        //desiredPosition.x = Mathf.Clamp(desiredPosition.x, minX, maxX);
        //desiredPosition.y = Mathf.Clamp(desiredPosition.y, minY, maxY);
        
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothness);
        transform.position = smoothedPosition;
    }
}
