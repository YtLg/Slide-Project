using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{

    public GameObject cBSpawner;
    public GameObject preCBall;
    public float force;
    public PlayerMoveScript pScript;

    private void Start()
    {
        pScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMoveScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if (pScript.LifeCheck())
            {
                Shoot();
            }
        }
    }

    void Shoot()
    {
        GameObject ball = Instantiate(preCBall, cBSpawner.transform.position, cBSpawner.transform.rotation);
        Rigidbody2D rigidBall = ball.GetComponent<Rigidbody2D>();
        rigidBall.AddForce(cBSpawner.transform.up * force, ForceMode2D.Impulse);

    }
}
