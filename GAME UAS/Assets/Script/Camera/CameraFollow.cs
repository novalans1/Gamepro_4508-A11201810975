using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    private Vector3 velocity = Vector3.zero;
    private Vector2 newPos;
    public float followOnDistance;


    void Update()
    {
        if (Vector2.Distance(transform.position, target.position) > followOnDistance)
        {
            newPos = target.position;
        }

        transform.position = Vector3.SmoothDamp(transform.position, newPos, ref velocity, 0.2f);
    }
}
