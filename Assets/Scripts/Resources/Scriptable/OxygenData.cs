using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Resources/Oxygen", order = 2)]
public class OxygenData : Resources
{
    public float oxygenHealth;
    public int oxygenAmount;
}
