using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healing : MonoBehaviour
{

    [SerializeField]
    private int healAmount;
    



    private GameObject thePlayer;
    
    private bool kitUsed = false;
    


    private void Awake()
    {
        thePlayer = GameObject.FindGameObjectWithTag("Player");

    }

    private void Heal()
    {
        thePlayer.GetComponent<PlayerHealth>().HealPlayer(healAmount);

    }

    private void OnTriggerEnter(Collider other)
    {
       
        if (thePlayer)
        {
     
                if (thePlayer.GetComponent<PlayerHealth>().currentHealth < thePlayer.GetComponent<PlayerHealth>().maxHealth)
                {
                    
                    Destroy(gameObject);
                }

                Heal();         
        }
           
    }

    

}
