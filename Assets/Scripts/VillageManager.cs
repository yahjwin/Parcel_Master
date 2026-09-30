using UnityEngine;

public class VillageManager : MonoBehaviour
{
    public GameObject endHouse;

    void OnEnable() 
    {
        if (PlayerPrefs.GetInt("Stage2Clear", 0) == 1)
        {
            endHouse.SetActive(true);
        }
        else
        {
            endHouse.SetActive(false);
        }
    }
}