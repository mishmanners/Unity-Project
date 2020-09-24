using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalculator : MonoBehaviour
{
    private string bill = "Bill";
    private int billCost = 40;
    public float tip = 20.0f;
    public float TotalCost;
    
    // Start is called before the first frame update
    void Start()
    {

        float Actualtip = billCost * (tip / 100);
        TotalCost = billCost + Actualtip;

        Debug.Log("Your bill is: $" + billCost + " and your tip amount is $" + Actualtip + " therefore you owe $" + TotalCost);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
