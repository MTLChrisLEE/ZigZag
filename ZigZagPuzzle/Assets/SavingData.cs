using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavingData : MonoBehaviour
{
    int number = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Stored number is: " + GetNumber());
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            number++;
            if(number > GetNumber())
            {
                PlayerPrefs.SetInt("MyInteger", number);
                Debug.Log(number);
            }
        }
        
    }

    int GetNumber()
    {
        return PlayerPrefs.GetInt("MyInteger", 0);
    }

}
