using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Name
{
    public string suffix;
    public string first;

    public Name(string suffix, string first)
    {
        this.suffix = suffix;
        this.first = first;
    }
    
}

[System.Serializable]

public class Customers: Name
{
    // public string firstName;
    // public string lastName;
    public int age;
    public string gender;
    public string occupation;

    public Customers(string suffix, string first, int age, string gender, string occupation) : base(suffix, first)
    {
        this.age = age;
        this.gender = gender;
        this.occupation = occupation;
    }

    
}
