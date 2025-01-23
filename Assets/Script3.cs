using UnityEngine;

public class Script3 : MonoBehaviour
{
    //input
    public int X;

    //bills
    private int hundreds;
    private int fifties;
    private int twenties;
    private int tens;
    private int fives;
    private int ones;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //hundreds
        hundreds = X / 100;
        X -= 100 * hundreds;

        //fifties
        fifties = X / 50;
        X -= 50 * fifties;

        //twenties
        twenties = X / 20;
        X-= 20 * twenties;

        //tens
        tens = X / 10;
        X -= 10 * tens;

        //fives
        fives = X / 5;
        X -= 5 * fives;

        //ones
        ones = X;

        //output
        Debug.Log($"Hundreds: {hundreds}\nFifties: {fifties}\nTwenties: {twenties}\nTens: {tens}\nFives: {fives}\nOnes: {ones}");
    }
}
