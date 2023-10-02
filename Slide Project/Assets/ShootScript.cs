using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{

    public GameObject cBSpawner;
    public GameObject preCBall;
    public float force;


    PlayerMoveScript pScript;
    PowSpawnScript powSScript;
    ShotgunScript gunScript;

    void Start()
    {
        gunScript = GameObject.FindGameObjectWithTag("Gun").GetComponent<ShotgunScript>();
        pScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMoveScript>();
        powSScript = GameObject.FindGameObjectWithTag("Powerup").GetComponent<PowSpawnScript>();
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
            GameObject ball = Instantiate(preCBall, cBSpawner.transform.position, Quaternion.Euler(0, 0, gunScript.GetRotation()));
        }

        void EmpShoot()
        {
            for (int i = 0; i < 3; i++)
            {
                GameObject ball = Instantiate(preCBall, cBSpawner.transform.position, cBSpawner.transform.rotation);
                Rigidbody2D rigidBall = ball.GetComponent<Rigidbody2D>();
                ball.transform.Rotate(0, 0, Random.Range(-15, 15));

        }
    }

}
