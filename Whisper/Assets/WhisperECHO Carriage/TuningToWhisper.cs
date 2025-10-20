using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//attach this to the NPC triggers
public class TuningToWhisper : MonoBehaviour
{
    [SerializeField] private int coreValue; //always random
    public PlayerManager playerManager;
    void Start()
    {
        coreValue = Random.Range(0,100);
        //playerStartValue = 50;
        playerManager.getCoreValue = coreValue;
    }
    
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            playerManager.canTune = true;
        }
    }
    void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player"))
        {
            playerManager.canTune = false;
        }
    }
}
