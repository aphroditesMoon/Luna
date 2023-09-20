using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace resources
{
    public class OxygenMonobehivor : IResources
    {
        public float Health { get; set; }
        public float Amount { get; set; }
        
        public IEnumerator ReduceOxygen()
        {
            while (Amount > 0)
            {
                Debug.Log("|s");
                yield return new WaitForSeconds(1);
                Amount -= 5.0f;
            }
        }
    }
}