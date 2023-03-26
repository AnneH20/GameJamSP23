using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using UnityEngine;
using TMPro;

public class MoneyScript : MonoBehaviour
{
    public TextMeshProUGUI moneyDue;
    public TextMeshProUGUI moneyPaid;
    public TextMeshProUGUI changeOwed;
    double due;
    double paid;
    double change;
    double amountDue;
    double amountPaid;
    double changeDue;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setMoney()
    {
        CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
        CultureInfo.CurrentUICulture = new CultureInfo("en-US", false);

        due = Random.Range(0f, 100f);
        //amountDue = due % 0.01;

        paid = Random.Range(0f, 100f);
        //amountPaid = paid % 0.01;

        if (paid > due)
        {
            string moneyD = string.Format("Total Due: {0:C2}", due);
            moneyDue.text = moneyD;

            string moneyP = string.Format("Amount Paid: {0:C2}", paid);
            moneyPaid.text = moneyP;

            change = paid - due;
            //changeDue = amountPaid - amountDue;
            string changeD = string.Format("Change Due: {0:C2}", change);
            changeOwed.text = changeD;
        }
        else
        {
            setMoney();
        }
    }
}
