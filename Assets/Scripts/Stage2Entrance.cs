using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage2Entrance : MonoBehaviour
{
    public string stage2SceneName = "Stage2Scene";

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(stage2SceneName);
        }
    }
}