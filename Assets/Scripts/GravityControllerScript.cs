using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class GravityControllerScript : MonoBehaviour
{
    [SerializeField] TMP_InputField numInput;
    [SerializeField] Slider sliderInput;

    [SerializeField] public void editGravityValue(float y)
    {
        Physics2D.gravity = new Vector3(0f, y, 0f);
    }

    [SerializeField] void InputToGravity(String newNum)
    {
        float floatNum;
        if (newNum.Length == 0 || newNum.StartsWith("-"))
        {
            floatNum = 0f;
        }
        floatNum = float.Parse(newNum);
        editGravityValue(floatNum);
    }

    [SerializeField] void SliderToGravity(float num)
    {
        numInput.text = Math.Round((decimal)num, 2).ToString();
        editGravityValue(num);
    }

    [SerializeField] void updateSlider(String newNum)
    {
        if (newNum.Length == 0 || (newNum.StartsWith("-") && newNum.Length == 1))
        {
            sliderInput.value = 0;
            return;
        }
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
                sliderInput.value = -20;
            }

        }
    }

    private bool VerifyInput(float num)
    {
        if (num > 20 || num < -20) return false;
        return true;
    }


}