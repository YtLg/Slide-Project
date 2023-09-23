using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rigid : MonoBehaviour
{

    public Rigidbody2D myRigidBody;
    public Camera myCamera;
    public float force;

    // Start is called before the first frame update
    void Start(){
        
    }


    // Update is called once per frame
    private void Update(){

    }

    //using FixedUpdate because I am applying physics to the object
    void FixedUpdate(){

        //gets the current position of the mouse
        Vector3 screenMousePos = Input.mousePosition;
        Vector3 worldMousePos = myCamera.ScreenToWorldPoint(screenMousePos);
        worldMousePos.z = 0f;


        if (Input.GetMouseButtonDown(0))
        {
            myRigidBody.velocity = Vector3.zero;

            Vector3 correctedDir = worldMousePos - transform.position;
            correctedDir = correctedDir.normalized;

            myRigidBody.AddForce(correctedDir * force * -1, ForceMode2D.Impulse);
        }
    }


}