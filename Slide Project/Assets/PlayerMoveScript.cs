using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour
{

    public Rigidbody2D myRigidBody;
    public Camera myCamera;
    public float force;

    LogicScript logic;

    bool isAlive;

    // Start is called before the first frame update
    void Start()
    {
        isAlive = true;
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
    }

    //using FixedUpdate because I am applying physics to the object
    void Update(){

        //gets the current position of the mouse
        Vector3 worldMousePos = logic.GetCorrPos();

        if (Input.GetMouseButtonDown(0) && isAlive == true)
        {
            myRigidBody.velocity = Vector3.zero;
            ApplyKnockback(worldMousePos);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isAlive = false;
        myRigidBody.velocity = Vector3.zero;
        Debug.Log("hit");
    }

    public bool LifeCheck()
    {
        return isAlive;
    }

    void ApplyKnockback(Vector3 mousePos)
    {
        Vector3 corrDir = logic.GetCorrDir(mousePos, transform.position);

        myRigidBody.AddForce(corrDir * -1 * force, ForceMode2D.Impulse);
    }


}