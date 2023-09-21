using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OOBScript : MonoBehaviour
{
    public GameObject player;
    public Camera myCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = playerPos = player.transform.position;

        if (System.Math.Abs(player.transform.position.y) > 5 || System.Math.Abs(player.transform.position.x) > 13)
        {
            player.transform.position = new Vector3(player.transform.position.x *-1, player.transform.position.y * -1, 0f);
        }

    }

        

}
