using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnScript : MonoBehaviour
{
    public PlayerMoveScript pScript;
    public GameObject enemy;
    public float spawnRate;
    public float counter;


    // Start is called before the first frame update
    void Start()
    {
        pScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMoveScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pScript.LifeCheck() == true)
        {
            if (counter < spawnRate)
            {
                counter += Time.deltaTime;
            }
            else
            {
                Instantiate(enemy, new Vector3(Random.Range(-12f, 12f), Random.Range(-4f, 4f), 0), transform.rotation);
                counter = 0;
            }
        }

    }
}
