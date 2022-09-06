using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cube : Primitive
{
    public override void DisplayText()
    {
        text.text = "This is a cube!";
    }
}
