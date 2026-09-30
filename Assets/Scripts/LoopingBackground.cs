using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    public float speed = 3f;

    public float resetX = -19;
    public float startX = 19f;

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        if (transform.position.x <= resetX)
        {
            Vector3 pos = transform.position;
            pos.x = startX;
            transform.position = pos;
        }
    }
}