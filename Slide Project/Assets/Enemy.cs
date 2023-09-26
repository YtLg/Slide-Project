using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public GameObject player;
    public PlayerMoveScript pScript;
    public Rigidbody2D enemyBody;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        // gets the player object since you can't drag it onto a prefab
        player = GameObject.FindGameObjectWithTag("Player");
        pScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMoveScript>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (pScript.LifeCheck() == true)
        {
            // Makes the enemy walk towards the player
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }
        else
        {
            enemyBody.velocity = Vector3.zero;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ball"))
        {
            Destroy(gameObject);
        }
    }

}
