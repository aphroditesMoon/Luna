using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace resources
{
    [CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Resources/Oxygen", order = 2)]
    public class OxygenData : Resources
    {
        public float oxygenHealth;
        public float oxygenAmount;

        float Resources.Health { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        float Resources.Amount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        IEnumerator Resources.ReduceOxygen()
        {
            throw new NotImplementedException();
        }
    }
}