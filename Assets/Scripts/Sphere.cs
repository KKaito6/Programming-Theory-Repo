using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Sphere : Primitive
{
    //POLYMORPHISM   
    public override void DisplayText()
    {
        text.text = "This is a sphere!";
    }
}
