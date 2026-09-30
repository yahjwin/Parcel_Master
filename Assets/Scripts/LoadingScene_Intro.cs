using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingIntroController : MonoBehaviour
{
    void Start()
    {
        Invoke(nameof(GoVillage), 2f);
    }

    void GoVillage()
    {
        SceneManager.LoadScene("VillageScene");
    }
}