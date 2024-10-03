using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    public float MoveSpeed;
    GameController gameController;

    void Start()
    {
        gameController = FindObjectOfType<GameController>();
    }

   
    void Update()
    {
        transform.position = transform.position + Vector3.left * MoveSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            gameController.RewardIncrement();
            Destroy(gameObject);

        }
        if (col.CompareTag("SceneLimit"))
        {
            Destroy(gameObject);
        }

    }

}
