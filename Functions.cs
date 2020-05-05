using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    public int total;
    public int total2;

    // Start is called before the first frame update
    void Start()
    {
        total = Sum(5, 2);
        total2 = Sum(10, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int Sum(int a, int b)
    {
        // Debug.Log(a + b);
        return a + b;
    }
}
