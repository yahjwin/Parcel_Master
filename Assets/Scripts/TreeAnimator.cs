using UnityEngine;

public class TreeAnimator : MonoBehaviour
{
    public Sprite tree1;
    public Sprite tree2;

    public float changeTime = 0.7f;

    private SpriteRenderer spriteRenderer;
    private float timer = 0f;
    private bool isTree2 = false;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = tree1;
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= changeTime)
        {
            timer = 0f;
            isTree2 = !isTree2;

            if (isTree2)
            {
                spriteRenderer.sprite = tree2;
            }
            else
            {
                spriteRenderer.sprite = tree1;
            }
        }
    }
}