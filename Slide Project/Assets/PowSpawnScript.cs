using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowSpawnScript : MonoBehaviour
{

    public PlayerMoveScript pScript;
    public GameObject powerUp;
    public float spawnRate;
    float counter;

    public float powTimer;
    float count2;

    public bool hasPow = false;

    // Start is called before the first frame update
    void Start()
    {
        hasPow = false;
        pScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMoveScript>();
    }

    // Update is called once per frame
    void Update()
    {
        PowUpTime();

        if (pScript.LifeCheck() && hasPow != true){
            if (counter < spawnRate)
            {
                counter += Time.deltaTime;
            }
            else
            {
                Instantiate(powerUp, new Vector3(Random.Range(-11f, 11f), Random.Range(-3.5f, 3.5f), 0), transform.rotation);
                counter = 0;
            }
        }
    }

    void PowUpTime()
    {
        if (GetPow() == true){
            if (count2 < powTimer)
            {
                count2 += Time.deltaTime;
            }

            else
            {
                SetPow(false);
                count2 = 0;
            }

        }
    }


    // allows other scripts to get the powerup and set the powerup status
    public bool GetPow()
    {
        return hasPow;
    }

    public void SetPow(bool input)
    {
        hasPow = input;
    }
}
