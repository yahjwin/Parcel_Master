using UnityEngine;

public class TruckCollision : MonoBehaviour
{
    public Stage2GameManager gameManager;

    private bool isHit = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!Stage2GameManager.instance.IsGameStarted || Stage2GameManager.instance.IsGameEnded)
        {
            return;
        }

        if (isHit) return;

        if (other.CompareTag("Obstacle"))
        {
            isHit = true;

            gameManager.TakeDamage();
            Destroy(other.gameObject);

            Invoke(nameof(ResetHit), 0.5f);
        }
    }

    void ResetHit()
    {
        isHit = false;
    }
}