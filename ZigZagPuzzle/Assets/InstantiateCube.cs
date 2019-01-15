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
        InvokeRepeating("CreateNewCube", 3.0F, 1.0F);     
    }

   
    public void CreateNewCube()
    {
        Instantiate(prefab, new Vector3(-15 + counter * 3.0F, 0, 0), Quaternion.identity);
        counter++;

        if (counter > 5)
        {
            CancelInvoke();
        }
    }
}
