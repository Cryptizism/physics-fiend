using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class MassControllerScript : MonoBehaviour
{
    [SerializeField] TMP_InputField numInput;
    [SerializeField] Slider sliderInput;
    private GameObject focusedObject;
    private Rigidbody2D focusedRigidbody;

    void Start()
    {
        focusedObject = GameObject.FindGameObjectWithTag("focused");
        if (focusedObject == null)
        {
            focusedObject = GameObject.FindGameObjectWithTag("Player");
        }
        focusedRigidbody = focusedObject.GetComponent<Rigidbody2D>();
        numInput.text = focusedRigidbody.mass.ToString();
        sliderInput.value = focusedRigidbody.mass;
    }

    [SerializeField]
    public void editMassValue(float magnitude)
    {
        focusedObject = GameObject.FindGameObjectWithTag("focused");
        if(focusedObject == null)
        {
            focusedObject = GameObject.FindGameObjectWithTag("Player");
        }
        focusedRigidbody = focusedObject.GetComponent<Rigidbody2D>();
        focusedRigidbody.mass = magnitude;
    }

    [SerializeField]
    public void InputToMass(String newNum)
    {
        float floatNum;
        floatNum = float.Parse(newNum);
        editMassValue(floatNum);
    }

    [SerializeField]
    public void SliderToMass(float num)
    {
        numInput.text = Math.Round((decimal)num, 2).ToString();
        editMassValue(num);
    }

    [SerializeField]
    public void updateMassSlider(String newNum)
    {
        float floatNum = float.Parse(newNum);
        if (VerifyInput(floatNum))
        {
            sliderInput.value = floatNum;
        }
        else
        {
            if (floatNum > 20)
            {
                sliderInput.value = 20;
            }
            else
            {
                sliderInput.value = 0;
            }

        }
    }

    private bool VerifyInput(float num)
    {
        if (num < 0 || num > 20) return false;
        return true;
    }
}