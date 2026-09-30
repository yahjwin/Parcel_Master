using UnityEngine;

public class ObstacleCar : MonoBehaviour
{
    public float speed = 3f;

    void Start()
    {
        int rand = Random.Range(0, 3);

        SpriteRenderer sr = GetComponent<SpriteRenderer>();

        if (sr != null)
        {
            if (rand == 0)
                sr.color = new Color(1f, 0.3f, 0.3f); // 빨강
            else if (rand == 1)
                sr.color = new Color(0.3f, 0.3f, 1f); // 파랑
            else
                sr.color = new Color(0.3f, 1f, 0.3f); // 초록
        }
    }

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        if (transform.position.x < -10f)
        {
            Destroy(gameObject);
        }
    }
}