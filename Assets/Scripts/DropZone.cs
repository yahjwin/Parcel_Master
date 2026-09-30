using UnityEngine;

public class DropZone : MonoBehaviour
{
    public int zoneType;
    public GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D other)
    {
        BoxData box = other.GetComponent<BoxData>();
        if (box == null) return;

        if (box.isProcessed) return;
        box.isProcessed = true;

        Debug.Log("박스 타입: " + box.boxType + " / 존 타입: " + zoneType);

        if (box.boxType == zoneType)
        {
            Debug.Log("정답!");
            gameManager.Correct();
        }
        else
        {
            Debug.Log("오답!");
            gameManager.Wrong();
        }

        Destroy(other.gameObject);
    }
}