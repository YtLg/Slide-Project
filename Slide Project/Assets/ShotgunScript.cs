using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotgunScript : MonoBehaviour
{

    public Camera myCamera;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 screenMousePos = Input.mousePosition;
        Vector3 worldMousePos = myCamera.ScreenToWorldPoint(screenMousePos);
        worldMousePos.z = 0f;

        //need to get the direction to the mouse position from where the player is currently standing
        // vector subtraction to get the vector A + (-B) which is the third vector that points from A to B.
        Vector3 corrDir = worldMousePos - player.transform.position;


        // to rotate the shotgun to point at the cursor it needs to know the angle at which to point at.
        // rather than a direction, so you need to convert the vector into a angle for the object to rotate towards
        // Atan2 converts to radians, so you need to conver that into Degrees with Rad2Deg
        // have to -90 deg because of Unity's degree system starts differently resulting in an incorrect angle
        float radToDegDir = Mathf.Atan2(corrDir.y, corrDir.x) * Mathf.Rad2Deg - 90f;

        //to rotate it to the correct angle
        transform.rotation = Quaternion.Euler(0,0,radToDegDir);

    }
}
