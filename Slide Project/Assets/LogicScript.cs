using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicScript : MonoBehaviour
{
    public GameObject player;
    public Camera myCamera;


    // Update is called once per frame
    void FixedUpdate()
    {
        OOBCheck();
    }

    void OOBCheck()
    {
        if (!(player.GetComponent<Renderer>().isVisible))
        {
            player.transform.position = new Vector3(player.transform.position.x * -1, player.transform.position.y * -1, 0f);
        }
    }


    // gets the mouse position in worldView and returns it
    public Vector3 GetCorrPos()
    {
        Vector3 screenMousePos = Input.mousePosition;
        Vector3 worldMousePos = myCamera.ScreenToWorldPoint(screenMousePos);
        worldMousePos.z = 0f;

        return worldMousePos;
    }


    // gets the corrected dirction between the source and the target and returns it
    public Vector3 GetCorrDir(Vector3 target, Vector3 source)
    {
        //need to get the direction to the mouse position from where the player is currently standing
        // vector subtraction to get the vector A + (-B) which is the third vector that points from A to B.

        Vector3 corrDir = target - source;
        corrDir = corrDir.normalized;
        return corrDir;
    }



}
