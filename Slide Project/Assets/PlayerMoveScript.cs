using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour
{

    public Rigidbody2D myRigidBody;
    public Camera myCamera;
    public float force;

    public LogicScript logic;

    bool isAlive;

    // Start is called before the first frame update
    void Start()
    {
        isAlive = true;
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
    }

    //using FixedUpdate because I am applying physics to the object
    void FixedUpdate(){

        //gets the current position of the mouse
        Vector3 worldMousePos = logic.GetCorrPos();

        if (Input.GetMouseButtonDown(0) && isAlive == true)
        {
            myRigidBody.velocity = Vector3.zero;

            Vector3 corrDir = logic.GetCorrDir(worldMousePos, transform.position);

            myRigidBody.AddForce(corrDir * force * -1, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isAlive = false;
        Debug.Log("hit");
    }


    public bool lifeCheck()
    {
        return isAlive;
    }
}