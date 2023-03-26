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

    public TextMeshProUGUI changeDisplay;
    public GameObject currency;
    private double amount = 0.00;

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

        if (currency.tag == "Penny")
        {
            amount = number * 0.01;
        }
        if (currency.tag == "Nickel")
        {
            amount = number * 0.05;
        }
        if (currency.tag == "Dime")
        {
            amount = number * 0.10;
        }
        if (currency.tag == "Quarter")
        {
            amount = number * 0.25;
        }
        if (currency.tag == "HalfDollar")
        {
            amount = number * 0.50;
        }

        if (currency.tag == "$1")
        {
            amount = number * 1.00;
        }
        if (currency.tag == "$5")
        {
            amount = number * 5.00;
        }
        if (currency.tag == "$10")
        {
            amount = number * 10.00;
        }
        if (currency.tag == "$20")
        {
            amount = number * 20.00;
        }
        if (currency.tag == "$50")
        {
            amount = number * 50.00;
        }
        if (currency.tag == "$100")
        {
            amount = number * 100.00;
        }

        UpdateText();
        Debug.Log("Currency amount: " + amount);
    }

    public void DecreaseNumber()
    {
        if (number > 0)
        {
            number--;
            PlayerPrefs.SetInt(scoreKey, number);

            if (currency.tag == "Penny")
            {
                amount = number * 0.01;
            }
            if (currency.tag == "Nickel")
            {
                amount = number * 0.05;
            }
            if (currency.tag == "Dime")
            {
                amount = number * 0.10;
            }
            if (currency.tag == "Quarter")
            {
                amount = number * 0.25;
            }
            if (currency.tag == "HalfDollar")
            {
                amount = number * 0.50;
            }

            if (currency.tag == "$1")
            {
                amount = number * 1.00;
            }
            if (currency.tag == "$5")
            {
                amount = number * 5.00;
            }
            if (currency.tag == "$10")
            {
                amount = number * 10.00;
            }
            if (currency.tag == "$20")
            {
                amount = number * 20.00;
            }
            if (currency.tag == "$50")
            {
                amount = number * 50.00;
            }
            if (currency.tag == "$100")
            {
                amount = number * 100.00;
            }
            UpdateText();
            Debug.Log("Currency amount: " + amount);
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
        CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
        CultureInfo.CurrentUICulture = new CultureInfo("en-US", false);
        textDisplay.text = number.ToString();
        string changeCreated = string.Format("Change Created: {0:C2}", amount);
        changeDisplay.text = changeCreated;
        Debug.Log("Update");
    }
}
