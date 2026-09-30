using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public Slider readyGauge;
    public TMP_Text resultText;
    public TMP_Text countdownText;
    public GameObject clearPanel;
    public BoxSpawner boxSpawner;

    public int gaugeValue = 0;
    public int correctAmount = 10;
    public int wrongPenalty = 5;

    public AudioSource audioSource;
    public AudioClip correctSound;
    public AudioClip wrongSound;
    public AudioClip clearSound;

    private bool gameStarted = false;
    private bool isCleared = false;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();

        if (audioSource == null)
            audioSource = gameObject.AddComponent<AudioSource>();

        audioSource.playOnAwake = false;
        audioSource.spatialBlend = 0f;
    }

    void Start()
    {
        Time.timeScale = 1f;

        readyGauge.minValue = 0;
        readyGauge.maxValue = 100;
        readyGauge.value = gaugeValue;

        resultText.text = "";

        if (clearPanel != null)
            clearPanel.SetActive(false);

        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        gameStarted = false;

        countdownText.gameObject.SetActive(true);

        for (int i = 5; i > 0; i--)
        {
            countdownText.text = i.ToString();
            yield return new WaitForSeconds(1f);
        }

        countdownText.text = "START!";
        yield return new WaitForSeconds(1f);

        countdownText.gameObject.SetActive(false);
        resultText.text = "택배를 분류하세요!";
        gameStarted = true;

        boxSpawner.StartSpawning();
    }

    public void Correct()
    {
        if (!gameStarted || isCleared) return;

        gaugeValue += correctAmount;

        if (gaugeValue > 100)
            gaugeValue = 100;

        readyGauge.value = gaugeValue;

        if (gaugeValue >= 100)
        {
            isCleared = true;
            gameStarted = false;

            resultText.text = "택배 분류 성공!";

            if (audioSource != null && clearSound != null)
                audioSource.PlayOneShot(clearSound);

            if (clearPanel != null)
                clearPanel.SetActive(true);

            Time.timeScale = 0f;
        }
        else
        {
            resultText.text = "정답! 배송 준비도 증가";

            if (audioSource != null && correctSound != null)
                audioSource.PlayOneShot(correctSound);
        }
    }

    public void Wrong()
    {
        if (!gameStarted || isCleared) return;

        gaugeValue -= wrongPenalty;

        if (gaugeValue < 0)
            gaugeValue = 0;

        readyGauge.value = gaugeValue;
        resultText.text = "오답! 배송 준비도 감소";

        if (audioSource != null && wrongSound != null)
            audioSource.PlayOneShot(wrongSound);
    }

    public void GoVillage()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("VillageScene");
    }
}