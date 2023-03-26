using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CurrencyUpdater : MonoBehaviour
{
    public TextMeshProUGUI displayText;
    private int totalCents = 0;
    private int numPennies = 0;
    private int numNickels = 0;
    private int numDimes = 0;
    private int numQuarters = 0;
    private int numHalfDollars = 0;
    private int numOneDollarBills = 0;
    private int numFiveDollarBills = 0;
    private int numTenDollarBills = 0;
    private int numTwentyDollarBills = 0;
    private int numFiftyDollarBills = 0;
    private int numOneHundredDollarBills = 0;

    public void IncreasePennies()
    {
        numPennies++;
        totalCents++;
        UpdateDisplay();
    }

    public void DecreasePennies()
    {
        if (numPennies > 0)
        {
            numPennies--;
            totalCents--;
            UpdateDisplay();
        }
    }

    public void IncreaseNickels()
    {
        numNickels++;
        totalCents += 5;
        UpdateDisplay();
    }

    public void DecreaseNickels()
    {
        if (numNickels > 0)
        {
            numNickels--;
            totalCents -= 5;
            UpdateDisplay();
        }
    }

    public void IncreaseDimes()
    {
        numDimes++;
        totalCents += 10;
        UpdateDisplay();
    }

    public void DecreaseDimes()
    {
        if (numDimes > 0)
        {
            numDimes--;
            totalCents -= 10;
            UpdateDisplay();
        }
    }

    public void IncreaseQuarters()
    {
        numQuarters++;
        totalCents += 25;
        UpdateDisplay();
    }

    public void DecreaseQuarters()
    {
        if (numQuarters > 0)
        {
            numQuarters--;
            totalCents -= 25;
            UpdateDisplay();
        }
    }

    public void IncreaseHalfDollars()
    {
        numHalfDollars++;
        totalCents += 50;
        UpdateDisplay();
    }

    public void DecreaseHalfDollars()
    {
        if (numHalfDollars > 0)
        {
            numHalfDollars--;
            totalCents -= 50;
            UpdateDisplay();
        }
    }

    public void IncreaseOneDollarBills()
    {
        numOneDollarBills++;
        totalCents += 100;
        UpdateDisplay();
    }

    public void DecreaseOneDollarBills()
    {
        if (numOneDollarBills > 0)
        {
            numOneDollarBills--;
            totalCents -= 100;
            UpdateDisplay();
        }
    }

    public void IncreaseFiveDollarBills()
    {
        numFiveDollarBills++;
        totalCents += 500;
        UpdateDisplay();
    }

    public void DecreaseFiveDollarBills()
    {
        if (numFiveDollarBills > 0)
        {
            numFiveDollarBills--;
            totalCents -= 500;
            UpdateDisplay();
        }
    }

    public void IncreaseTenDollarBills()
    {
        numTenDollarBills++;
        totalCents += 1000;
        UpdateDisplay();
    }

    public void DecreaseTenDollarBills()
    {
        if (numTenDollarBills > 0)
        {
            numTenDollarBills--;
            totalCents -= 1000;
            UpdateDisplay();
        }
    }

    public void IncreaseTwentyDollarBills()
    {
        numTwentyDollarBills++;
        totalCents += 2000;
        UpdateDisplay();
    }

    public void DecreaseTwentyDollarBills()
    {
        if (numTwentyDollarBills > 0)
        {
            numTwentyDollarBills--;
            totalCents -= 2000;
            UpdateDisplay();
        }
    }

    public void IncreaseFiftyDollarBills()
    {
        numFiftyDollarBills++;
        totalCents += 5000;
        UpdateDisplay();
    }

    public void DecreaseFiftyDollarBills()
    {
        if (numFiftyDollarBills > 0)
        {
            numFiftyDollarBills--;
            totalCents -= 5000;
            UpdateDisplay();
        }
    }

    public void IncreaseOneHundredDollarBills()
    {
        numOneHundredDollarBills++;
        totalCents += 10000;
        UpdateDisplay();
    }

    public void DecreaseOneHundredDollarBills()
    {
        if (numOneHundredDollarBills > 0)
        {
            numOneHundredDollarBills--;
            totalCents -= 10000;
            UpdateDisplay();
        }
    }


    private void UpdateDisplay()
    {
        decimal totalDollars = (decimal)totalCents / 100m;
        string formattedTotal = totalDollars.ToString("C2");
        string displayTextString = "Total: " + formattedTotal + "\n" +
                                   "Pennies: " + numPennies + "\n" +
                                   "Nickels: " + numNickels + "\n" +
                                   "Dimes: " + numDimes + "\n" +
                                   "Quarters: " + numQuarters + "\n" +
                                   "Half Dollars: " + numHalfDollars + "\n" +
                                   "One Dollar Bills: " + numOneDollarBills + "\n" +
                                   "Five Dollar Bills: " + numFiveDollarBills + "\n" +
                                   "Ten Dollar Bills: " + numTenDollarBills + "\n" +
                                   "Twenty Dollar Bills: " + numTwentyDollarBills + "\n" +
                                   "Fifty Dollar Bills: " + numFiftyDollarBills + "\n" +
                                   "One Hundred Dollar Bills: " + numOneHundredDollarBills;
        displayText.text = displayTextString;
    }

}
