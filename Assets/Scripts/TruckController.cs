using UnityEngine;

public class TruckController : MonoBehaviour
{
    public float fixedX = -6.5f;
    public float[] laneY = { -1.5f, 0f, 1.5f };
    public int currentLane = 1;

    public float moveSpeed = 10f;

    public AudioSource audioSource;
    public AudioClip crashSound;

    private SpriteRenderer spriteRenderer;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();

        if (audioSource == null)
            audioSource = gameObject.AddComponent<AudioSource>();

        audioSource.playOnAwake = false;
        audioSource.spatialBlend = 0f;

        spriteRenderer = GetComponent<SpriteRenderer>();

        if (spriteRenderer != null)
        {
            spriteRenderer.enabled = true;
            spriteRenderer.sortingOrder = 50;
        }
    }

    void Start()
    {
        currentLane = 1;
        transform.position = new Vector3(fixedX, laneY[currentLane], -1f);
        transform.localScale = new Vector3(0.3f, 0.3f, 1f);
    }

    void Update()
    {
        transform.position = new Vector3(fixedX, transform.position.y, -1f);

        if (!Stage2GameManager.instance.IsGameStarted || Stage2GameManager.instance.IsGameEnded)
            return;

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            currentLane++;
            if (currentLane > 2) currentLane = 2;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            currentLane--;
            if (currentLane < 0) currentLane = 0;
        }

        Vector3 targetPos = new Vector3(fixedX, laneY[currentLane], -1f);
        transform.position = Vector3.Lerp(transform.position, targetPos, moveSpeed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            if (audioSource != null && crashSound != null)
                audioSource.PlayOneShot(crashSound);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle"))
        {
            if (audioSource != null && crashSound != null)
                audioSource.PlayOneShot(crashSound);
        }
    }
}