using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
    private Rigidbody rigidbody;
    private bool walkingRight = true;
    private Animator animator;
    private GameManager gameManager;

    public Transform rayStart;


    // Start is called before the first frame update
    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangePosition();
        }

        RaycastHit hit;

        if (!Physics.Raycast(rayStart.position, -transform.up, out hit, Mathf.Infinity))
        {
            animator.SetTrigger("isFalling");
        }

        if(transform.position.y < -2)
        {
            gameManager.EndGame();
        }
        
    }

   private void FixedUpdate()
    {
        if (!gameManager.gameStarted)
        {
            return;
        }else
        {
            animator.SetTrigger("gameStarted");
        }

        rigidbody.position = transform.position + transform.forward * 2 * Time.deltaTime;
    }

    private void ChangePosition()
    {
        if (!gameManager.gameStarted)
        {
            return;
        }

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

    private void OnTriggerEnter(Collider crystal)
    {
        if(crystal.tag == "Crystal")
        {
            Destroy(crystal.gameObject);
            gameManager.IncreaseScore();
        }
    }

}
