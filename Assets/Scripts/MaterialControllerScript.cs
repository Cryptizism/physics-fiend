using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MaterialControllerScript : MonoBehaviour
{
    public PhysicsMaterial2D[] optionMaterials;

    public TMP_Dropdown dropdown;

    private GameObject player;

    private BoxCollider2D Collider2D;

    // Start is called before the first frame update
    void Start()
    {
        List<string> optionNames = new List<string>();
        for(int i = 0; i < optionMaterials.Length; i++)
        {
            optionNames.Add(optionMaterials[i].name);
        }
        dropdown.ClearOptions();
        dropdown.AddOptions(optionNames);
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void optionClicked(Int32 num)
    {
        Collider2D = player.GetComponent<BoxCollider2D>();
        Collider2D.sharedMaterial = optionMaterials[num];
    }
}
