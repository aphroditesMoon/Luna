using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace resources
{
    public interface Resources
    {
        public enum ResourcesTypes
        {
            oxygen, 
        }

        public float Health { get; set; }
        public float Amount { get; set; }

        IEnumerator ReduceOxygen();

        //public static void InstantiateResources(Resources resourceses, Resources resources, GameObject resourcesObject)
        //{
        //    resourceses.amount = resources.amount;
        //    resourceses.health = resources.health;

        //    IEnumerator ReduceOxygen();
        //}
    }
}