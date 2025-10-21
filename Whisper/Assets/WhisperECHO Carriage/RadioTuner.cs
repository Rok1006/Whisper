using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioTuner : MonoBehaviour
{
    public PlayerManager pm;
    [Header("Tuning Values")]
    //public float value = 0f;           // current tuning value
    //public float targetValue = 50f;    // correct frequency
    public float maxDistance = 50f;    // how far before it goes silent

    [Header("Audio")]
    public AudioSource radioAudio;     // assign your audio source in Inspector
    public float maxVolume = 1f;       // loudest volume at perfect tune
    public float fadeSpeed = 3f;       // how quickly volume adjusts

    void Start() {
        pm = this.GetComponent<PlayerManager>();
        radioAudio = pm.passengerAudio;
    }
    void Update()
    {
        //radioAudio.volume = 0;

        // Smoothly adjust current volume
        if(pm.canTune){
            radioAudio = pm.passengerAudio;
        // Calculate distance from target
            float distance = Mathf.Abs(pm.playerStartValue - pm.getCoreValue);

        // Convert distance into "closeness" (1 = perfect, 0 = far away)
            float closeness = Mathf.Clamp01(1f - (distance / maxDistance));

        // Target volume based on closeness
            float targetVolume = closeness * maxVolume;
            radioAudio.volume = Mathf.Lerp(radioAudio.volume, targetVolume, Time.deltaTime * fadeSpeed);
        }
    }
        
}
