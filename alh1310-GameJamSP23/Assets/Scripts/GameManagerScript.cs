using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.Globalization;
using UnityEngine.UI;


public class GameManagerScript : MonoBehaviour
{
    //public MoneyScript moneyScript;
    public AudioSource buttonSound;
    public AudioClip button;

    public AudioClip correct;
    public AudioClip wrong;

    /*
    public AmountUpdater pennyUpdater;
    public AmountUpdater nickelUpdater;
    public AmountUpdater dimeUpdater;
    public AmountUpdater quarterUpdater;
    public AmountUpdater halfdollarUpdater;

    public AmountUpdater oneUpdater;
    public AmountUpdater fiveUpdater;
    public AmountUpdater tenUpdater;
    public AmountUpdater twentyUpdater;
    public AmountUpdater fiftyUpdater;
    public AmountUpdater hundredUpdater;
    */

    public GameObject settingsMenu;
    public GameObject gameOver;
    public GameObject scoreTxt;
    public GameObject resetButton;

    public GameObject amountTitle;
    public GameObject amountPaid;
    public GameObject changeAmount;
    public GameObject submitButton;

    public GameObject pennyAmount;
    public GameObject nickelAmount;
    public GameObject dimeAmount;
    public GameObject quarterAmount;
    public GameObject halfdollarAmount;

    public GameObject oneAmount;
    public GameObject fiveAmount;
    public GameObject tenAmount;
    public GameObject twentyAmount;
    public GameObject fiftyAmount;
    public GameObject hundredAmount;

    public GameObject changeCreated;

    public static bool isPaused;

    public TextMeshProUGUI moneyDue;
    public TextMeshProUGUI moneyPaid;
    public TextMeshProUGUI changeOwed;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI finalScoreText;

    double due;
    double paid;
    double change;
    double changeDue;
    private int score;
    string changed;

    public TextMeshProUGUI submitButtonText;
    private CurrencyUpdater currentUpdate;

    // Start is called before the first frame update
    private void Start()
    {
        /*
        pennyUpdater.ResetScore();
        nickelUpdater.ResetScore();
        dimeUpdater.ResetScore();
        quarterUpdater.ResetScore();
        halfdollarUpdater.ResetScore();

        oneUpdater.ResetScore();
        fiveUpdater.ResetScore();
        tenUpdater.ResetScore();
        twentyUpdater.ResetScore();
        fiftyUpdater.ResetScore();
        hundredUpdater.ResetScore();
        */
        score = 0;
        setMoney();
        currentUpdate = FindObjectOfType<CurrencyUpdater>();
        changeCreated.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SettingsMenu()
    {
        buttonSound.PlayOneShot(button);
        settingsMenu.SetActive(true);

        amountTitle.SetActive(false);
        amountPaid.SetActive(false);
        changeAmount.SetActive(false);
        submitButton.SetActive(false);

        pennyAmount.SetActive(false);
        nickelAmount.SetActive(false);
        dimeAmount.SetActive(false);
        quarterAmount.SetActive(false);
        halfdollarAmount.SetActive(false);

        oneAmount.SetActive(false);
        fiveAmount.SetActive(false);
        tenAmount.SetActive(false);
        twentyAmount.SetActive(false);
        fiftyAmount.SetActive(false);
        hundredAmount.SetActive(false);

        changeCreated.SetActive(false);
        resetButton.SetActive(false);

        Time.timeScale = 0f;
        isPaused = true;
    }

    public void Resume()
    {
        buttonSound.PlayOneShot(button);
        settingsMenu.SetActive(false);

        //amountTitle.SetActive(true);
        //amountPaid.SetActive(true);
        changeAmount.SetActive(true);
        submitButton.SetActive(true);

        pennyAmount.SetActive(true);
        nickelAmount.SetActive(true);
        dimeAmount.SetActive(true);
        quarterAmount.SetActive(true);
        halfdollarAmount.SetActive(true);

        oneAmount.SetActive(true);
        fiveAmount.SetActive(true);
        tenAmount.SetActive(true);
        twentyAmount.SetActive(true);
        fiftyAmount.SetActive(true);
        hundredAmount.SetActive(true);

        changeCreated.SetActive(false);
        resetButton.SetActive(true);

        Time.timeScale = 1f;
        isPaused = false;
    }

    public void setMoney()
    {
        CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
        CultureInfo.CurrentUICulture = new CultureInfo("en-US", false);

        if (score < 5)
        {
            due = System.Math.Round((double)UnityEngine.Random.Range(0f, 100f), 2);
            paid = System.Math.Round((double)UnityEngine.Random.Range(0f, 100f), 2);
        }
        if (score >= 5 && score < 10)
        {
            due = System.Math.Round((double)UnityEngine.Random.Range(0f, 500f), 2);
            paid = System.Math.Round((double)UnityEngine.Random.Range(0f, 500f), 2);
        }
        if (score >= 10 && score < 15)
        {
            due = System.Math.Round((double)UnityEngine.Random.Range(0f, 1000f), 2);
            paid = System.Math.Round((double)UnityEngine.Random.Range(0f, 1000f), 2);
        }
        if (score >= 15)
        {
            due = System.Math.Round((double)UnityEngine.Random.Range(0f, 5000f), 2);
            paid = System.Math.Round((double)UnityEngine.Random.Range(0f, 5000f), 2);
        }

        if (paid > due)
        {
            string moneyD = string.Format("Total Due: {0:C}", due);
            //moneyDue.text = moneyD;

            string moneyP = string.Format("Amount Paid: {0:C}", paid);
            //moneyPaid.text = moneyP;

            change = paid - due;
            //changeDue = amountPaid - amountDue;
            string changeD = string.Format("Change Due: {0:C}", change);
            changed = change.ToString("C2");
            changeOwed.text = changeD;
        }
        else
        {
            setMoney();
        }
    }

    public void OnSubmit()
    {
        buttonSound.PlayOneShot(button);
        if (changed == currentUpdate.formattedTotal)
        {
            buttonSound.PlayOneShot(correct);
            Debug.Log("Correct!");
            Debug.Log("Change Due: " + changed);
            Debug.Log("Change Paid: " + currentUpdate.formattedTotal);
            score++;
            scoreText.text = "Score: " + score;

            setMoney();
        }
        else
        {
            buttonSound.PlayOneShot(wrong);
            Debug.Log("Incorrect!");
            Debug.Log("Change Due: " + changed);
            Debug.Log("Change Paid: " + currentUpdate.formattedTotal);
            GameOver();
            finalScoreText.text = "Score: " + score;
        }
    }

    public void GameOver()
    {
        gameOver.SetActive(true);

        amountTitle.SetActive(false);
        amountPaid.SetActive(false);
        changeAmount.SetActive(false);
        submitButton.SetActive(false);

        pennyAmount.SetActive(false);
        nickelAmount.SetActive(false);
        dimeAmount.SetActive(false);
        quarterAmount.SetActive(false);
        halfdollarAmount.SetActive(false);

        oneAmount.SetActive(false);
        fiveAmount.SetActive(false);
        tenAmount.SetActive(false);
        twentyAmount.SetActive(false);
        fiftyAmount.SetActive(false);
        hundredAmount.SetActive(false);

        changeCreated.SetActive(false);
        resetButton.SetActive(false);

        scoreTxt.SetActive(false);

        Time.timeScale = 0f;
    }

    public void MainMenu()
    {
        buttonSound.PlayOneShot(button);
        SceneManager.LoadScene("MainMenu");
    }

    public void PlayAgain()
    {
        buttonSound.PlayOneShot(button);
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex);
    }
}
