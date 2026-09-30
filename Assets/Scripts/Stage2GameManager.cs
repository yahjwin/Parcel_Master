using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Stage2GameManager : MonoBehaviour
{
    public static Stage2GameManager instance;

    [Header("HP")]
    public Image[] hearts;
    public int hp = 5;

    [Header("UI")]
    public GameObject gameOverPanel;
    public GameObject gameClearPanel;
    public TextMeshProUGUI countdownText;
    public TextMeshProUGUI timerText;

    [Header("Time")]
    public float gameTime = 20f;

    [Header("Sound")]
    public AudioSource audioSource;
    public AudioClip gameOverSound;
    public AudioClip clearSound;

    private float currentTime;
    private bool isGameStarted = false;
    private bool isGameEnded = false;

    public bool IsGameStarted => isGameStarted;
    public bool IsGameEnded => isGameEnded;

    void Awake()
    {
        instance = this;

        audioSource = GetComponent<AudioSource>();

        if (audioSource == null)
            audioSource = gameObject.AddComponent<AudioSource>();

        audioSource.playOnAwake = false;
        audioSource.spatialBlend = 0f;
    }

    void Start()
    {
        Time.timeScale = 0f;

        hp = 5;
        UpdateHearts();

        gameOverPanel.SetActive(false);
        gameClearPanel.SetActive(false);

        currentTime = gameTime;
        timerText.text = "TIME : " + Mathf.CeilToInt(currentTime);

        countdownText.gameObject.SetActive(true);

        StartCoroutine(StartCountdown());
    }

    IEnumerator StartCountdown()
    {
        isGameStarted = false;
        isGameEnded = false;

        for (int i = 5; i > 0; i--)
        {
            countdownText.text = i.ToString();
            yield return new WaitForSecondsRealtime(1f);
        }

        countdownText.text = "START!";
        yield return new WaitForSecondsRealtime(0.7f);

        countdownText.gameObject.SetActive(false);

        Time.timeScale = 1f;
        isGameStarted = true;
    }

    void Update()
    {
        if (!isGameStarted || isGameEnded)
            return;

        currentTime -= Time.deltaTime;
        timerText.text = "TIME : " + Mathf.CeilToInt(currentTime);

        if (currentTime <= 0)
        {
            GameClear();
        }
    }

    public void TakeDamage()
    {
        if (!isGameStarted || isGameEnded)
            return;

        hp--;

        if (hp < 0)
            hp = 0;

        UpdateHearts();

        if (hp <= 0)
        {
            GameOver();
        }
    }

    void UpdateHearts()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            hearts[i].gameObject.SetActive(i < hp);
        }
    }

    void GameOver()
    {
        if (isGameEnded) return;

        isGameEnded = true;
        isGameStarted = false;

        if (audioSource != null && gameOverSound != null)
            audioSource.PlayOneShot(gameOverSound);

        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    void GameClear()
    {
        if (isGameEnded) return;

        isGameEnded = true;
        isGameStarted = false;

        PlayerPrefs.SetInt("Stage2Clear", 1);
        PlayerPrefs.Save();

        if (audioSource != null && clearSound != null)
            audioSource.PlayOneShot(clearSound);

        gameClearPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Stage2Scene");
    }

    public void GoVillage()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("VillageScene");
    }
}