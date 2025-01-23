using UnityEngine;

public class Task1 : MonoBehaviour
{
    // The purpose of the code is to imput a score for every criteria and output the final challenging score of a course 

    public string NameCourse;
    //  In engine imput the desired ammount for each criteria 
    public float ScoreModules;
    public float ScoreReadings;
    public float ScoreQuizzes;
    public float ScoreAssignments;
    public float ScoreExp;
    private float FinalScore;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // multiply percentage with given scores to determine final result 
        ScoreModules *= 0.15f;
        ScoreReadings *= 0.3f;
        ScoreQuizzes *= 0.15f;
        ScoreAssignments *= 0.3f;
        ScoreExp *= 0.1f;

        // add all to find final socre
        FinalScore = ScoreModules + ScoreReadings + ScoreQuizzes + ScoreAssignments + ScoreExp;
        Debug.Log(NameCourse + "Final challenge score: " + FinalScore);
    
    }
}

