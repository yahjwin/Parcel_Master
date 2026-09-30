using System.Collections;
using UnityEngine;
using TMPro;

public class CountdownManager : MonoBehaviour
{
    public TMP_Text countdownText;
    public BoxSpawner boxSpawner;

    void Start()
    {
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        countdownText.text = "5";
        yield return new WaitForSeconds(1f);

        countdownText.text = "4";
        yield return new WaitForSeconds(1f);

        countdownText.text = "3";
        yield return new WaitForSeconds(1f);

        countdownText.text = "2";
        yield return new WaitForSeconds(1f);

        countdownText.text = "1";
        yield return new WaitForSeconds(1f);

        countdownText.text = "Ω√¿€!";
        yield return new WaitForSeconds(0.5f);

        countdownText.text = "";
        boxSpawner.StartSpawning();
    }
}