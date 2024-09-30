using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public float MoveSpeed;
    GameController gameController;
    void Start()
    {
        gameController = FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + Vector3.left * MoveSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Points"))
        {
            gameController.ScoreInCrement();
            Debug.Log("Point");
        }
        if (col.CompareTag("SceneLimit"))
        {
            Debug.Log("end");

            Destroy(gameObject);
        }
    }





}
