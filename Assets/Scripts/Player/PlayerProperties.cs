using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerProperties : MonoBehaviour
{
    [SerializeField] PlayerData playerData;

    [SerializeField] private Slider healthSlider;
    [SerializeField] private Slider hungerSlider;
    [SerializeField] private Slider oxygenSlider;
    
    private float _health;
    private float _hungerStatus;
    private float _oxygenAmount;

    private void Awake()
    {
        _health = playerData.health;
        _hungerStatus = playerData.hungerStatus;
        _oxygenAmount = playerData.oxygenAmount;
    }

    private void Start()
    {
        //StartCoroutine(ReduceOxygen());
        //StartCoroutine(ReduceHungerStatus());
    }

    private void Update()
    {
        healthSlider.value = _health;
        hungerSlider.value = _hungerStatus;
        oxygenSlider.value = _oxygenAmount;
    }

    private IEnumerator ReduceOxygen()
    {
        while (_oxygenAmount > 0)
        {
            yield return new WaitForSeconds(1);
            _oxygenAmount -= 5.0f;
        }
    }
    
    private IEnumerator ReduceHungerStatus()
    {
        while (_hungerStatus > 0)
        {
            yield return new WaitForSeconds(1);
            _hungerStatus -= 2.5f;
        }
    }
}
