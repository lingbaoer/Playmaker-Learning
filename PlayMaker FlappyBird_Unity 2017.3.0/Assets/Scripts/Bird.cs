using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private Rigidbody2D rigidbody2d;
    private PlayMakerFSM fsm;

    private void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        fsm = GetComponent<PlayMakerFSM>();
    }

    public void AddForce(Vector2 force)
    {
        Vector2 velocity = rigidbody2d.velocity;
        velocity.y = 0;
        rigidbody2d.velocity = velocity;
        rigidbody2d.AddForce(force);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        fsm.SendEvent("GameOver");
    }
}
