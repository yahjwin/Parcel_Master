using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 3f;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector3 move = new Vector3(x, y, 0).normalized;

        transform.position += move * speed * Time.deltaTime;

        if (move.magnitude > 0)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }
    }
}