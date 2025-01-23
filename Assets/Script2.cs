using UnityEngine;

public class Script2 : MonoBehaviour
{
    public float X = 0f;
    public float Y = 0f;
    private float cost = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cost += Y * (X * .6f);
        if (Y > 0)
        {
            cost += 3f;
            if (Y > 1)
            {
                cost +=.75f * (Y - 1); 
            }
        }
        Debug.Log(cost);
    }
}
