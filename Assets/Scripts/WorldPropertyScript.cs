using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldPropertyScript : MonoBehaviour
{

    [SerializeField] GameObject[] properties;

    private GameObject content;

    void Start()
    {
        content = GameObject.FindGameObjectWithTag("UI Content");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            GameObject childObject;

            foreach (Transform child in content.transform)
            {
                GameObject.Destroy(child.gameObject);
            }

            for (var i = 0; i < properties.Length; i++)
            {
                childObject = Instantiate(properties[i]) as GameObject;
                childObject.transform.SetParent(content.transform, false);
            }
        }
    }
}
