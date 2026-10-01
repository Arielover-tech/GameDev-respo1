using UnityEngine;

public class DemoScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    int numLives = 3;
    //declare and initialize a floating print number//
    float energy = 0.3f;
    //declare and initiate a string value// 
    string message = "Hello";

    void Start()
    {
        Print(numLives);
        //add one xtra Life to the variable and print the value of varible//
        numLives=numLives+1;
        Print(numLives);
        //

        Print(energy);
        energy=energy+1.5; 
        Print(message);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
