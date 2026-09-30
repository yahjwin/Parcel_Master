using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    public GameObject boxPrefab;

    [Header("Box Sprites")]
    public Sprite rabbitBoxSprite;
    public Sprite foxBoxSprite;
    public Sprite dogBoxSprite;

    public float minX = -4f;
    public float maxX = 4f;
    public float spawnY = 4.5f;

    public float spawnDelay = 2f;
    public int spawnCount = 2;

    public void StartSpawning()
    {
        CancelInvoke(nameof(SpawnBoxes));
        InvokeRepeating(nameof(SpawnBoxes), 0.5f, spawnDelay);
    }

    void SpawnBoxes()
    {
        for (int i = 0; i < spawnCount; i++)
        {
            SpawnBox();
        }
    }

    void SpawnBox()
    {
        float randomX = Random.Range(minX, maxX);
        Vector3 spawnPos = new Vector3(randomX, spawnY, 0);

        GameObject newBox = Instantiate(boxPrefab, spawnPos, Quaternion.identity);

        newBox.transform.localScale = new Vector3(0.25f, 0.25f, 1f);

        int randType = Random.Range(1, 4);

        BoxData boxData = newBox.GetComponent<BoxData>();
        boxData.boxType = randType;

        SpriteRenderer sr = newBox.GetComponent<SpriteRenderer>();

        if (randType == 1)
        {
            sr.sprite = rabbitBoxSprite;
        }
        else if (randType == 2)
        {
            sr.sprite = foxBoxSprite;
        }
        else
        {
            sr.sprite = dogBoxSprite;
        }

        sr.color = Color.white;
        sr.sortingOrder = 10;

        Rigidbody2D rb = newBox.GetComponent<Rigidbody2D>();
        rb.gravityScale = 0.15f;
    }
}