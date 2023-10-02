using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{

    public GameObject cBSpawner;
    public GameObject preCBall;
    public float force;

    LogicScript logic;
    PlayerMoveScript pScript;
    PowSpawnScript powSScript;



    private int x;

    private void Start()
    {
        pScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMoveScript>();
        powSScript = GameObject.FindGameObjectWithTag("Powerup").GetComponent<PowSpawnScript>();
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
    }
    // Update is called once per frame
    void Update()
    {
            if (Input.GetMouseButtonDown(0))
            {
                if (powSScript.GetPow())
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
            for (x = 0; x < 3; x++)
            {
                Debug.Log("Shot no." + x);
                GameObject ball = Instantiate(preCBall, cBSpawner.transform.position, cBSpawner.transform.rotation);
                Rigidbody2D rigidBall = ball.GetComponent<Rigidbody2D>();
                rigidBall.AddForce(cBSpawner.transform.up * force, ForceMode2D.Impulse);
            }

        }
}
