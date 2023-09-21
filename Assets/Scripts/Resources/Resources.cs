using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace resources
{
    public interface IResources
    {
        public enum ResourcesTypes
        {
            Oxygen, 
        }

        public float Health { get; set; }
        public float Amount { get; set; }

        void ReduceOxygen();
    }
}