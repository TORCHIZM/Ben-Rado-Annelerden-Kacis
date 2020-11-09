using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterMove : MonoBehaviour
{
    public float Velocity = 1f;

    public Rigidbody2D CharacterRigidBody2D;
    public Canvas DeadCanvas;
    public Text ScoreLabel;

    public bool IsDead;
    public bool IsStarted;
    private int Score = 0;

    private void Start()
    {
        DeadCanvas.enabled = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CharacterRigidBody2D.velocity = Vector2.up * Velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Untagged")
        {
            IsDead = true;
            DeadCanvas.enabled = true;
            Time.timeScale = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Point")
        {
            this.Score++;

            if (Score == 31)
                ScoreLabel.text = "SJSJ";
            else
                this.ScoreLabel.text = $"{this.Score}";
        }
    }
}
