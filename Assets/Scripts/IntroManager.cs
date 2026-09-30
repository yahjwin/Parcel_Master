using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroManager : MonoBehaviour
{
    public GameObject startPanel;
    public GameObject storyPanel;
    public GameObject howToPanel;

    void Start()
    {
        PlayerPrefs.DeleteKey("Stage2Clear");

        startPanel.SetActive(true);
        storyPanel.SetActive(false);
        howToPanel.SetActive(false);
    }

    public void ShowStory()
    {
        startPanel.SetActive(false);
        storyPanel.SetActive(true);
        howToPanel.SetActive(false);
    }

    public void ShowHowTo()
    {
        startPanel.SetActive(false);
        storyPanel.SetActive(false);
        howToPanel.SetActive(true);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("LoadingScene_Intro");
    }
}