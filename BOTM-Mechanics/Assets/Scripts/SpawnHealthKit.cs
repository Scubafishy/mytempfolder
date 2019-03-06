using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHealthKit : MonoBehaviour
{
    public GameObject healthSpawnPoint;

    public bool lookingAtHealthSpawn = false;

    private void Update()
    {
        SpawnHealthInput();
        
    }
    private void SpawnHealthInput()
    {
        if (Input.GetButtonDown("UseTele") && lookingAtHealthSpawn== true)
        {
            healthSpawnPoint.GetComponent<SpawnpointHealthKit>().SpawnKit();
            //Destroy(healthSpawnPoint);
            healthSpawnPoint = null;
            
        }
    }

    private void SetHealthSpawnPoint(GameObject gameObject)
    {
        
        healthSpawnPoint = gameObject;     
        healthSpawnPoint.GetComponent<Renderer>().material.color = Color.blue;
        lookingAtHealthSpawn = true;
    }

    private void ResetHealthSpawnPoint()
    {
        
        lookingAtHealthSpawn = false;
       
        if (healthSpawnPoint != null)
        {
            healthSpawnPoint.GetComponent<Renderer>().material.color = Color.white;
        }

        
    }

    private void OnEnable()
    {
        DetectObject.HealSpawnDetected += SetHealthSpawnPoint;
        DetectObject.HealSpawnGone += ResetHealthSpawnPoint;
    }

    private void OnDisable()
    {
        DetectObject.HealSpawnDetected -= SetHealthSpawnPoint;
        DetectObject.HealSpawnGone -= ResetHealthSpawnPoint;
    }
}
