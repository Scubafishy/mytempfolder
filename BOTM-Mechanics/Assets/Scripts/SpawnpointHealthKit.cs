using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnpointHealthKit : MonoBehaviour
{
    [SerializeField]
    private GameObject healthKit;
    [SerializeField]
    private GameObject exactSpawnpoint;
    [SerializeField]
    private int numberTospawn;

    private bool spawnUsed = false;
    private void Update()
    {
        if(spawnUsed == true)
        {
            Destroy(gameObject);
            
        }
    }
    public void SpawnKit()
    {

        this.transform.position
        new Vector3(1, 0, 0)
        if (numberTospawn > 0)
        {
            SpawnKit();
            numberTospawn--;
            Instantiate(healthKit, exactSpawnpoint.transform.position, Quaternion.Euler(0, 0, 0));


        }
        else
        {
            spawnUsed = true;
        }


    }
}
