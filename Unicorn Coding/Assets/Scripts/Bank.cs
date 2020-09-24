using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Bank
{
    protected string branchName;
    protected string location;
    protected string cashInVault;
    
    public void CheckBalance()
    {
        Debug.Log("Let me check the balance of your " + branchName);
    }

    public void Withdrawal()
    {
        Debug.Log("Oh so you wanna take $ from your " + branchName + " account? Sure, let's take ALL the money.");


    }

    public void Deposit()
    {

        Debug.Log("You're depositing money into your " + branchName + " account.");

    }

}
