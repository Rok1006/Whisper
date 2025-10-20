using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextCarUI : MonoBehaviour
{
    [SerializeField] private GameObject NCTrigger;

    void Start() {
        NCTrigger.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Triggered by: " + other.name);

        if (other.CompareTag("Player"))
        {
            NCTrigger.SetActive(true);
            //Debug.Log("Player entered the trigger!");
        }
    }
    void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player"))
        {
            NCTrigger.SetActive(false);
            //Debug.Log("Player entered the trigger!");
        }
    }
}
