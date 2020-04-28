using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassFail : MonoBehaviour
{
    public float Quiz1;
    public float Quiz2;
    public float Quiz3;
    public float Quiz4;
    public float Quiz5;

    public void CheckGrade(int grade, string quizName)
    {
        // A > 80
        // B 70-79
        // C 60-69
        // Pass 50 - 59
        // Fail < 49

        if (grade >= 80)
        {
            Debug.Log("Congrats you got an A for " + quizName + ". Your score was " + grade);
        }
        else if (grade >= 70 && grade <= 79)
        {
            Debug.Log("You got a B for " + quizName + ". Your score was " + grade);
        }
        else if (grade >= 60 && grade <= 69)
        {
            Debug.Log("You got a C for " + quizName + ". Your score was " + grade);
        }
        else if (grade >= 50 && grade <= 59)
        {
            Debug.Log("Well done you passed the " + quizName + ". Ps get degrees. Your score was " + grade);
        }
        else
        {
            Debug.Log("Sorry you failed the " + quizName + ". Your score was " + grade);
        }
    }


        // Start is called before the first frame update
        void Start()
    {
        Random random = new Random();
        Quiz1 = Random.Range(0, 100);
        Quiz2 = Random.Range(0, 100);
        Quiz3 = Random.Range(0, 100);
        Quiz4 = Random.Range(0, 100);
        Quiz5 = Random.Range(0, 100);

        float average = (Quiz1 + Quiz2 + Quiz3 + Quiz4 + Quiz5) / 5;

        Debug.Log("Here is the quiz average. The average of all the quizzes is " + average);

        CheckGrade((int)Quiz1, "1. Maths Test");
        CheckGrade((int)Quiz2, "2. Science Quiz");
        CheckGrade((int)Quiz3, "3. Arts Painting");
        CheckGrade((int)Quiz4, "4. Cake Making");
        CheckGrade((int)Quiz5, "5. Programming Exam");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
