using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rigid : MonoBehaviour
{

    public Rigidbody2D myRigidBody;
    public Camera myCamera;

    public float force;
    public float minForceX;
    public float minForceY;

    private float xForce;
    private float yForce;


    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        //gets the current position of the mouse
        Vector3 screenMousePos = Input.mousePosition;
        Vector3 worldMousePos = myCamera.ScreenToWorldPoint(screenMousePos);
        worldMousePos.z = 0f;
 
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 dir = worldMousePos - transform.position;
            dir = dir.normalized;
            myRigidBody.AddForce(dir * force * -1);
        }
    }
}