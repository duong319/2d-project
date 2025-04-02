using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public float MoveSpeed;
    GameController gameController;
    AudioManager audioManager;
    void Start()
    {
        gameController = FindObjectOfType<GameController>();
        audioManager=GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
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
            audioManager.PlaySFX(audioManager.getPoint);
        }
        if (col.CompareTag("SceneLimit"))
        {
            Debug.Log("end");

            Destroy(gameObject);
        }
    }





}
