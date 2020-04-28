using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizCalculator : MonoBehaviour
{
    public float Quiz1;
    public float Quiz2;
    public float Quiz3;
    public float Quiz4;
    public float Quiz5;


    // Start is called before the first frame update
    void Start()
    {
        Random random = new Random();
        Quiz1 = Random.Range(0, 10);
        Quiz2 = Random.Range(0, 10);
        Quiz3 = Random.Range(0, 10);
        Quiz4 = Random.Range(0, 10);
        Quiz5 = Random.Range(0, 10);

        float grade = (Quiz1 + Quiz2 + Quiz3 + Quiz4 + Quiz5) / 5;

        Debug.Log("Here is the quiz average. The average of all the quizzes is " + grade);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
