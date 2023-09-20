using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rigid : MonoBehaviour
{

    public Rigidbody2D myRigidBody;
    public Camera myCamera;
    public int force;
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        // gets the current position of the mouse
        Vector3 mousePos = Input.mousePosition;
        Vector3 convMousePos = myCamera.ScreenToWorldPoint(mousePos);
        convMousePos.z = 0f;

        if (Input.GetMouseButtonDown(0)){
            myRigidBody.AddForce(convMousePos * (force   * -1));
        } 
    }
}
