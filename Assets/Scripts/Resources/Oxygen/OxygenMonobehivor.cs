using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace resources
{
    public class OxygenMonobehivor : IResources
    {
        public float Health { get; set; }
        public float Amount { get; set; }
        
        public void ReduceOxygen()
        {
            Health = 5f;
            Amount = 12f;
            Debug.Log(Health);
            Debug.Log(Amount);
        }
    }
}