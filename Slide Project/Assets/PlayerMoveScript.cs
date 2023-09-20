using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rigid : MonoBehaviour
{

    public Rigidbody2D myRigidBody;
    public Camera myCamera;
    public float force;
    public float maxForce;
    private Vector3 newForceMouse;
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        // gets the current position of the mouse
        Vector3 screenMousePos = Input.mousePosition;
        Vector3 worldMousePos = myCamera.ScreenToWorldPoint(screenMousePos);
        worldMousePos.z = 0f;
        Debug.Log(worldMousePos);

        if (Input.GetMouseButtonDown(0)){


            // Find how close a value is to 0, then if it's closer than a theshold e.g. number is closer to 0 than 3 digits, then add 10 to it.
            // for negatives, you may have to find the absolute value such as if number = negative then number * -1, if newNumber < 3 then newNumber + 10 * -1;

            // note to self: you probably could have done if vector.x < 10, vector +10 or smth in order to make it so numbers smaller send the player further without altering the direction
        } 
    }
}


//float xMousePos = (worldMousePos.x + force);
//float yMousepos = (worldMousePos.y + force);

//if (xMousePos > maxForce && yMousepos > maxForce)
//{
//    newForceMouse = new Vector3(maxForce, maxForce, 0);
//}
//else if (xMousePos > maxForce)
//{
//    newForceMouse = new Vector3(maxForce, yMousepos, 0);
//}
//else if (yMousepos > maxForce)
//{
//    newForceMouse = new Vector3(xMousePos, maxForce, 0);
//}
//else
//{
//    newForceMouse = worldMousePos;
//}
//myRigidBody.AddForce(newForceMouse * -1);