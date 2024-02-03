using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    GameController p_controller;

    private void Start()
    {
        p_controller = FindObjectOfType<GameController>();
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            p_controller.PlusScore();
            Destroy(gameObject);
            Debug.Log("Da do duoc bong");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("LoseZone"))
        {
            p_controller.SetPlayerState(true);
            Destroy(gameObject);
            Debug.Log("Game over");
        }
    }
}
