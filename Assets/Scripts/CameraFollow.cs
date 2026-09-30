using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 5f;

    public Vector2 minPosition;
    public Vector2 maxPosition;

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 targetPos = new Vector3(target.position.x, target.position.y, transform.position.z);

        targetPos.x = Mathf.Clamp(targetPos.x, minPosition.x, maxPosition.x);
        targetPos.y = Mathf.Clamp(targetPos.y, minPosition.y, maxPosition.y);

        transform.position = Vector3.Lerp(transform.position, targetPos, smoothSpeed * Time.deltaTime);
    }
}