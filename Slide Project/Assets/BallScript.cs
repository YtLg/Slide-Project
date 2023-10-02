using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public float force;
    // Update is called once per frame
    void FixedUpdate()
    {
        Rigidbody2D rigidBall = this.GetComponent<Rigidbody2D>();
        rigidBall.AddForce(rigidBall.transform.up * force, ForceMode2D.Impulse);

        // if the cannonball is off-screen, destroy it
        if ( !(GetComponent<Renderer>().isVisible) )
        {
            Destroy(gameObject);
        }
    }

    // upon colliding with something with a solid rigidbody, destroy this object.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") | collision.gameObject.CompareTag("Player"))
            Destroy(gameObject);
    }

}
