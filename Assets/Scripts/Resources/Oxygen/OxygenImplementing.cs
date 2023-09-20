using System;
using System.Collections;
using System.Collections.Generic;
using resources;
using UnityEngine;

public class OxygenImplementing : MonoBehaviour
{
    private void Start()
    { 
        OxygenMonobehivor oxygenMonobehivor = new OxygenMonobehivor();

        TestInterface(oxygenMonobehivor);
    }

    private void TestInterface(IResources resources)
    {
        resources.ReduceOxygen();
    }
}
