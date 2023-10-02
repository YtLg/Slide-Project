using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class PowScript : MonoBehaviour
{
    public PowSpawnScript powSScript;


    // Start is called before the first frame update
    void Start()
    {
        powSScript = GameObject.FindGameObjectWithTag("Powerup").GetComponent<PowSpawnScript>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Pow up collected");
            powSScript.SetPow(true);
            Destroy(gameObject);
        }
    }
}
