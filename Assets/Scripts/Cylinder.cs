using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cylinder : Primitive
{
    //POLYMORPHISM
    public override void DisplayText()
    {
        text.text = "This is a cylinder!";
    }
}
