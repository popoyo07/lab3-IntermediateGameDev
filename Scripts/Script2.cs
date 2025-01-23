using UnityEngine;

public class Script2 : MonoBehaviour
{
    public float X = 0f;
    public float Y = 0f;
    private float cost = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //wholesale book cost with discount
        cost += Y * (X * .6f);

        //if any books bought
        if (Y > 0)
        {
            //first book shipping cost
            cost += 3f;

            //if more books bought
            if (Y > 1)
            {
                //additional book shipping cost
                cost +=.75f * (Y - 1); 
            }
        }
        //output
        Debug.Log(cost);
    }
}
