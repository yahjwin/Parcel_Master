using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    public Sprite standSprite;
    public Sprite walkSprite;

    public float changeTime = 0.1f;

    private SpriteRenderer spriteRenderer;
    private float timer = 0f;
    private bool isWalkFrame = false;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = standSprite;
    }

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        bool isMoving = moveX != 0 || moveY != 0;

        if (moveX != 0)
        {
            spriteRenderer.flipX = moveX > 0;
        }

        if (isMoving)
        {
            timer += Time.deltaTime;

            if (timer >= changeTime)
            {
                timer = 0f;
                isWalkFrame = !isWalkFrame;

                spriteRenderer.sprite = isWalkFrame ? walkSprite : standSprite;
            }
        }
        else
        {
            timer = 0f;
            isWalkFrame = false;
            spriteRenderer.sprite = standSprite;
        }
    }
}