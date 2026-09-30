using UnityEngine;

public class ConveyorScroll : MonoBehaviour
{
    public float speed = 2f;
    public float height = 6f;

    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (transform.position.y <= -height)
        {
            transform.position += new Vector3(0, height * 2, 0);
        }
    }
}