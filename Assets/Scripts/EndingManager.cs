using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingManager : MonoBehaviour
{
    public void GoStart()
    {
    
        PlayerPrefs.DeleteKey("Stage2Clear");

        SceneManager.LoadScene("StartScene");
    }
}