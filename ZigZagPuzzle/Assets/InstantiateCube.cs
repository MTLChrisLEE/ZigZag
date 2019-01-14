using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateCube : MonoBehaviour
{
    public Transform prefab;
    int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
               
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, new Vector3(-15 + counter * 3.0F, 0, 0), Quaternion.identity);
            counter++;
        }
    }
}
