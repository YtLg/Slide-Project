using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{

    public GameObject cBSpawner;
    public GameObject preCBall;
    public float force;
    public PlayerMoveScript pScript;
    public PowSpawnScript powScript;

    private void Start()
    {
        pScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMoveScript>();
        powScript = GameObject.FindGameObjectWithTag("Powerup").GetComponent<PowSpawnScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if (powScript.GetPow())
            {
                EmpShoot();
            }

            else if (pScript.LifeCheck())
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

    void EmpShoot()
    {
        Debug.Log("Works");
        GameObject ball1 = Instantiate(preCBall, cBSpawner.transform.position, cBSpawner.transform.rotation);
        GameObject ball2 = Instantiate(preCBall, cBSpawner.transform.position, cBSpawner.transform.rotation);
        GameObject ball3 = Instantiate(preCBall, cBSpawner.transform.position, cBSpawner.transform.rotation);


        Rigidbody2D rigidBall1 = ball1.GetComponent<Rigidbody2D>();
        Rigidbody2D rigidBall2 = ball2.GetComponent<Rigidbody2D>();
        Rigidbody2D rigidBall3 = ball3.GetComponent<Rigidbody2D>();

        rigidBall1.AddForce(cBSpawner.transform.up * force, ForceMode2D.Impulse);
        rigidBall2.AddForce(cBSpawner.transform.up * force, ForceMode2D.Impulse);
        rigidBall3.AddForce(cBSpawner.transform.up * force, ForceMode2D.Impulse);


    }
}
