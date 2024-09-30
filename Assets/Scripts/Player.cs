using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float flyPower;
    Rigidbody2D rb;
    GameController gameController;
    private Animator animator;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gameController = FindObjectOfType<GameController>();
        animator = FindObjectOfType<Animator>();
        animator.SetFloat("flyPower", 0);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(1))
        {
            rb.AddForce(new Vector2(0, flyPower));

        }
        animator.SetFloat("flyPower", rb.velocity.y);
    }

 

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("DeathZone")||col.gameObject.CompareTag("Obstacle"))
        {
            gameController.SetGameOverState(true);

        }
    }

   

}
