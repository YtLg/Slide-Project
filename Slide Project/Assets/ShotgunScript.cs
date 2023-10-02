        using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotgunScript : MonoBehaviour
{

    public Camera myCamera;
    public GameObject player;

    LogicScript logic;
    PlayerMoveScript pScript;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
        pScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMoveScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pScript.LifeCheck() == true)
        {
            Vector3 corrDir = logic.GetCorrDir(logic.GetCorrPos(), player.transform.position);

            // to rotate the shotgun to point at the cursor it needs to know the angle at which to point at.
            // rather than a direction, so you need to convert the vector into a angle for the object to rotate towards
            // Atan2 converts to radians, so you need to conver that into Degrees with Rad2Deg
            // have to -90 deg because of Unity's degree system starts differently resulting in an incorrect angle
            float radToDegDir = Mathf.Atan2(corrDir.y, corrDir.x) * Mathf.Rad2Deg - 90f;

            //to rotate it to the correct angle
            transform.rotation = Quaternion.Euler(0, 0, radToDegDir);
        }

    }
}
