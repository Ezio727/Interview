using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B : Person
{
    private void Start()
    {
        firstName = "B";
        lastName = "C";
        age = 30;

        Debug.Log("first name " + firstName + "/n age" + age);
    }
}
