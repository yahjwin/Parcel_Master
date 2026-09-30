using UnityEngine;

public class DragObject : MonoBehaviour
{
    private Vector3 offset;

    void OnMouseDown()
    {
        offset = transform.position - GetMouseWorldPos();
    }

    void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + offset;
    }

    Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = 0f; 
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
}