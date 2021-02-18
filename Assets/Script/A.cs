using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A : Person
{
    void Start()
    {
        firstName = "A";
        lastName = "C";
        age = 22;
        Debug.Log("first name " + firstName + "/n age" + age);
    }

}
