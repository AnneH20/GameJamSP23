using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Globalization;

public class AmountUpdater : MonoBehaviour
{
    public TextMeshProUGUI textDisplay; // text number for each money
    private int number = 0; // number for each money
    private string scoreKey = "Number"; 

    private void Start()
    {
        number = PlayerPrefs.GetInt(scoreKey, 0);
        UpdateText();
        Debug.Log("Start");
    }

    public void IncreaseNumber()
    {
        number++;
        PlayerPrefs.SetInt(scoreKey, number);
        UpdateText();
        Debug.Log("Increase");
    }

    public void DecreaseNumber()
    {
        if (number > 0)
        {
            number--;
            PlayerPrefs.SetInt(scoreKey, number);
            UpdateText();
            Debug.Log("Decrease");
        }

    }

    public void ResetScore()
    {
        PlayerPrefs.SetInt(scoreKey, 0);
        number = 0;
        UpdateText();
        Debug.Log("Reset");
    }

    private void UpdateText()
    {
        textDisplay.text = number.ToString();
        Debug.Log("Update");
    }
}
