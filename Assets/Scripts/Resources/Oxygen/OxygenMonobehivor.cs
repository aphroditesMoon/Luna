using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace resources
{
    public class OxygenMonobehivor : MonoBehaviour
    {
        //private void Start()
        //{
        //    StartCoroutine(ReduceOxygen());
        //}

        private void Update()
        {
            //Resources.ResourcesTypes.oxygen = OxygenData.;

            Debug.Log(Resources.ResourcesTypes.oxygen);
        }

        IEnumerator ReduceOxygen(Resources resources)
        {
            while (resources.Amount > 0)
            {
                yield return new WaitForSeconds(1);
                resources.Amount -= 5.0f;
            }
        }
    }
}