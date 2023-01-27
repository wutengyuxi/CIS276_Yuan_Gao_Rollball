using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    //Common data types: int, float, string, bool
    int myInt = 4;
    float myFloat = 4.36f; //have to add f at end to make a float
    string myString = "This is my string";
    bool myBool = true;  //No initiation makes it false
    
    
    private void Awake() //Awake is called when Unity starts
    {


    }
    
    void Start() // Start is called before the first frame update
    {
        int sum = 0;
        sum = myInt + 20;
        int b = myInt * 6;
        int c = myInt / 3;
        int d = myInt % 3;

        Debug.Log(sum);
        Debug.Log(b);
        Debug.Log(c);
        Debug.Log(d);
    }

    private void FixedUpdate() //FixedUpdate is called once per physics frame; for changes to Physics objects
    {

    }

    // Update is called once per frame to check logic written inside
    void Update()
    {
        
    }
}
