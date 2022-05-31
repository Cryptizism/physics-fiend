using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangingTextScript : MonoBehaviour
{
    public String[] Script;
    public int delay;
    public TMP_Text TextElem;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(cycleText());
    }

    // Update is called once per frame
    
    IEnumerator cycleText()
    {
        for (int i = 0; i < Script.Length; i++)
        {
            TextElem.text = Script[i];
            yield return new WaitForSeconds(delay);
        }
    }
}
