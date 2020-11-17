using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Employee : MonoBehaviour
{
    public int employeeName;
    public int companyName;
}

public class FullTime : Employee
{
    CalculateMonthlySalary();
}

public class PartTime : Employee
{
    CalculateMonthlySalary();
}
