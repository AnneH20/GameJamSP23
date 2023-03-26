using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public MoneyScript moneyScript;

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


    public GameObject settingsMenu;

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

    // Start is called before the first frame update
    private void Start()
    {
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

        moneyScript.setMoney();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SettingsMenu()
    {
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

        Time.timeScale = 0f;
        isPaused = true;
    }

    public void Resume()
    {
        settingsMenu.SetActive(false);

        amountTitle.SetActive(true);
        amountPaid.SetActive(true);
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

        changeCreated.SetActive(true);

        Time.timeScale = 1f;
        isPaused = false;
    }
}
