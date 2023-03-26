using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CurrencyUpdater : MonoBehaviour
{
    public TextMeshProUGUI currencyCounter;
    public TextMeshProUGUI penniesCounter;
    public TextMeshProUGUI nickelsCounter;
    public TextMeshProUGUI dimesCounter;
    public TextMeshProUGUI quartersCounter;
    public TextMeshProUGUI halfdollarsCounter;

    public TextMeshProUGUI onebillCounter;
    public TextMeshProUGUI fivebillCounter;
    public TextMeshProUGUI tenbillCounter;
    public TextMeshProUGUI twentybillCounter;
    public TextMeshProUGUI fiftybillCounter;
    public TextMeshProUGUI onehundredbillCounter;

    public AudioSource buttonSound;
    public AudioClip button;

    private double totalCents = 0;
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

    public double totalDollars = 0.00;
    public string formattedTotal;

    public bool isReset;

    public void IncreasePennies()
    {
        buttonSound.PlayOneShot(button);
        numPennies++;
        totalCents += 1.00;
        isReset = false;
        UpdateDisplay();
    }

    public void DecreasePennies()
    {
        buttonSound.PlayOneShot(button);
        if (numPennies > 0)
        {
            numPennies--;
            totalCents -= 1.00;
            isReset = false;
            UpdateDisplay();
        }
    }

    public void IncreaseNickels()
    {
        buttonSound.PlayOneShot(button);
        numNickels++;
        totalCents += 5.00;
        isReset = false;
        UpdateDisplay();
    }

    public void DecreaseNickels()
    {
        buttonSound.PlayOneShot(button);
        if (numNickels > 0)
        {
            numNickels--;
            totalCents -= 5.00;
            isReset = false;
            UpdateDisplay();
        }
    }

    public void IncreaseDimes()
    {
        buttonSound.PlayOneShot(button);
        numDimes++;
        totalCents += 10.00;
        isReset = false;
        UpdateDisplay();
    }

    public void DecreaseDimes()
    {
        buttonSound.PlayOneShot(button);
        if (numDimes > 0)
        {
            numDimes--;
            totalCents -= 10.00;
            isReset = false;
            UpdateDisplay();
        }
    }

    public void IncreaseQuarters()
    {
        buttonSound.PlayOneShot(button);
        numQuarters++;
        totalCents += 25.00;
        isReset = false;
        UpdateDisplay();
    }

    public void DecreaseQuarters()
    {
        buttonSound.PlayOneShot(button);
        if (numQuarters > 0)
        {
            numQuarters--;
            totalCents -= 25.00;
            isReset = false;
            UpdateDisplay();
        }
    }

    public void IncreaseHalfDollars()
    {
        buttonSound.PlayOneShot(button);
        numHalfDollars++;
        totalCents += 50.00;
        isReset = false;
        UpdateDisplay();
    }

    public void DecreaseHalfDollars()
    {
        buttonSound.PlayOneShot(button);
        if (numHalfDollars > 0)
        {
            numHalfDollars--;
            totalCents -= 50.00;
            isReset = false;
            UpdateDisplay();
        }
    }

    public void IncreaseOneDollarBills()
    {
        buttonSound.PlayOneShot(button);
        numOneDollarBills++;
        totalCents += 100.00;
        isReset = false;
        UpdateDisplay();
    }

    public void DecreaseOneDollarBills()
    {
        buttonSound.PlayOneShot(button);
        if (numOneDollarBills > 0)
        {
            numOneDollarBills--;
            totalCents -= 100.00;
            isReset = false;
            UpdateDisplay();
        }
    }

    public void IncreaseFiveDollarBills()
    {
        buttonSound.PlayOneShot(button);
        numFiveDollarBills++;
        totalCents += 500.00;
        isReset = false;
        UpdateDisplay();
    }

    public void DecreaseFiveDollarBills()
    {
        buttonSound.PlayOneShot(button);
        if (numFiveDollarBills > 0)
        {
            numFiveDollarBills--;
            totalCents -= 500.00;
            isReset = false;
            UpdateDisplay();
        }
    }

    public void IncreaseTenDollarBills()
    {
        buttonSound.PlayOneShot(button);
        numTenDollarBills++;
        totalCents += 1000.00;
        isReset = false;
        UpdateDisplay();
    }

    public void DecreaseTenDollarBills()
    {
        buttonSound.PlayOneShot(button);
        if (numTenDollarBills > 0)
        {
            numTenDollarBills--;
            totalCents -= 1000.00;
            isReset = false;
            UpdateDisplay();
        }
    }

    public void IncreaseTwentyDollarBills()
    {
        buttonSound.PlayOneShot(button);
        numTwentyDollarBills++;
        totalCents += 2000.00;
        isReset = false;
        UpdateDisplay();
    }

    public void DecreaseTwentyDollarBills()
    {
        buttonSound.PlayOneShot(button);
        if (numTwentyDollarBills > 0)
        {
            numTwentyDollarBills--;
            totalCents -= 2000.00;
            isReset = false;
            UpdateDisplay();
        }
    }

    public void IncreaseFiftyDollarBills()
    {
        buttonSound.PlayOneShot(button);
        numFiftyDollarBills++;
        totalCents += 5000;
        UpdateDisplay();
        isReset = false;
    }

    public void DecreaseFiftyDollarBills()
    {
        buttonSound.PlayOneShot(button);
        if (numFiftyDollarBills > 0)
        {
            numFiftyDollarBills--;
            totalCents -= 5000.00;
            isReset = false;
            UpdateDisplay();
        }
    }

    public void IncreaseOneHundredDollarBills()
    {
        buttonSound.PlayOneShot(button);
        numOneHundredDollarBills++;
        totalCents += 10000.00;
        isReset = false;
        UpdateDisplay();
    }

    public void DecreaseOneHundredDollarBills()
    {
        buttonSound.PlayOneShot(button);
        if (numOneHundredDollarBills > 0)
        {
            numOneHundredDollarBills--;
            totalCents -= 10000.00;
            isReset = false;
            UpdateDisplay();
        }
    }

    public void ResetAmount()
    {
        buttonSound.PlayOneShot(button);
        numPennies = 0;
        numNickels = 0;
        numDimes = 0;
        numQuarters = 0;
        numHalfDollars = 0;
        numOneDollarBills = 0;
        numFiveDollarBills = 0;
        numTenDollarBills = 0;
        numTwentyDollarBills = 0;
        numFiftyDollarBills = 0;
        numOneHundredDollarBills = 0;
        totalDollars = 0.00;
        totalCents = 0;
        isReset = true;
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        if (!isReset)
        {
            totalDollars = totalCents / 100;
            formattedTotal = totalDollars.ToString("C2");
            string displayTextString = "Change Created: " + formattedTotal;
            currencyCounter.text = displayTextString;
            string penniesDisplay = numPennies.ToString();
            string nickelsDisplay = numNickels.ToString();
            string dimesDisplay = numDimes.ToString();
            string quartersDisplay = numQuarters.ToString();
            string halfdollarDisplay = numHalfDollars.ToString();
            string onedollarDisplay = numOneDollarBills.ToString();
            string fivedollarDisplay = numFiveDollarBills.ToString();
            string tendollarDisplay = numTenDollarBills.ToString();
            string twentydollarDisplay = numTwentyDollarBills.ToString();
            string fiftydollarDisplay = numFiftyDollarBills.ToString();
            string onehundreddollarDisplay = numOneHundredDollarBills.ToString();

            penniesCounter.text = penniesDisplay;
            nickelsCounter.text = nickelsDisplay;
            dimesCounter.text = dimesDisplay;
            quartersCounter.text = quartersDisplay;
            halfdollarsCounter.text = halfdollarDisplay;

            onebillCounter.text = onedollarDisplay;
            fivebillCounter.text = fivedollarDisplay;
            tenbillCounter.text = tendollarDisplay;
            twentybillCounter.text = twentydollarDisplay;
            fiftybillCounter.text = fiftydollarDisplay;
            onehundredbillCounter.text = onehundreddollarDisplay;
        }
        else
        {
            formattedTotal = totalDollars.ToString("C2");
            string displayTextString = "Change Created: " + formattedTotal;
            currencyCounter.text = displayTextString;
            string penniesDisplay = numPennies.ToString();
            string nickelsDisplay = numNickels.ToString();
            string dimesDisplay = numDimes.ToString();
            string quartersDisplay = numQuarters.ToString();
            string halfdollarDisplay = numHalfDollars.ToString();
            string onedollarDisplay = numOneDollarBills.ToString();
            string fivedollarDisplay = numFiveDollarBills.ToString();
            string tendollarDisplay = numTenDollarBills.ToString();
            string twentydollarDisplay = numTwentyDollarBills.ToString();
            string fiftydollarDisplay = numFiftyDollarBills.ToString();
            string onehundreddollarDisplay = numOneHundredDollarBills.ToString();

            penniesCounter.text = penniesDisplay;
            nickelsCounter.text = nickelsDisplay;
            dimesCounter.text = dimesDisplay;
            quartersCounter.text = quartersDisplay;
            halfdollarsCounter.text = halfdollarDisplay;

            onebillCounter.text = onedollarDisplay;
            fivebillCounter.text = fivedollarDisplay;
            tenbillCounter.text = tendollarDisplay;
            twentybillCounter.text = twentydollarDisplay;
            fiftybillCounter.text = fiftydollarDisplay;
            onehundredbillCounter.text = onehundreddollarDisplay;
        }

    }

}
