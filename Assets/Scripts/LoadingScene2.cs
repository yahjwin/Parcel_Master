using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScene2Controller : MonoBehaviour
{
    void Start()
    {
        Invoke(nameof(GoStage1), 2f);
    }

    void GoStage1()
    {
        SceneManager.LoadScene("Stage1Scene");
    }
}