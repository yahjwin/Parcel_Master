using UnityEngine;
using UnityEngine.SceneManagement;

public class EndHouse : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Áý¿¡ ´êÀ½: " + other.name);

        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("EndingScene");
        }
    }
}