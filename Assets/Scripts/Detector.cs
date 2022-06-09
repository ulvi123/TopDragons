using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
    {


    }


    // void OnTriggerEnter2D(Collider2D col)
    // {
    //     if (gameObject.CompareTag("Obstacle"))
    //     {
    //         if (col.gameObject.CompareTag("Player"))
    //         {
    //             GameObject.FindObjectOfType<GameManager>()?.GameOver();
    //         }
    //     }
    //     else if (gameObject.CompareTag("Scoring"))
    //     {
    //         if (col.CompareTag("Player"))
    //         {
    //             GameObject.FindObjectOfType<GameManager>()?.IncreaseScore();
    //         }
    //     }

    // }
}
