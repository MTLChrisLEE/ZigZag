using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
    private Rigidbody rigidbody;
    private bool walkingRight = true;


    // Start is called before the first frame update
    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangePosition();
        }
        
    }

   private void FixedUpdate()
    {
        rigidbody.position = transform.position + transform.forward * 2 * Time.deltaTime;
    }

    private void ChangePosition()
    {
        this.walkingRight = !this.walkingRight;

        if(this.walkingRight)
        {
            transform.rotation = Quaternion.Euler(0, 45, 0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, -45, 0);
        }

    }
}
