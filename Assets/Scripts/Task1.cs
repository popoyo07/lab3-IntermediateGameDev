using UnityEngine;

public class Task1 : MonoBehaviour
{
    // The purpose of the code is to imput a score for every criteria and output the final challenging score of a course 

    public string NameCourse;
    //  In engine imput the desired ammount for each criteria 
    public float ScoreModules;
    public float ScoreReadings;
    public float ScoreQuizzes;
    public float ScoreExp;

    // The porcentage value of each criteria 
    private float Modules = 0.15f;
    private float Readings = 0.3f;
    private float Quizzes = 0.15f;
    private float Exp = 0.10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Display how much of each was input 
        Debug.Log("This course has the following Challenging scores ");
        Debug.Log("Modules: " + ScoreModules  + "\n" +
                   "Reading: " + ScoreReadings + "\n" +
                   "Quizz: " + ScoreReadings + "\n" +
                   "Experience: " + ScoreReadings );

        // multiply percentage with given scores to determine final result 
        Modules *= ScoreModules;
        Readings *= ScoreReadings;
        Quizzes *= ScoreQuizzes;
        Exp *= ScoreExp;

        Debug.Log("Modules: " + Modules + "\n" + 
                   "Reading: " + Readings + "\n" +
                   "Quizz: " + Quizzes + "\n" +
                   "Experience: " + Exp);

        // add all to find final socre
        private float FinalScore = Modules + Readings + Quizzes + Exp;
        Debug.Log($ " {NameCourse} Final challenge score: {FinalScore}");

    }
}
