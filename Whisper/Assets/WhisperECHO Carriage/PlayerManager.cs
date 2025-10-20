using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private GameObject Radio;
    [SerializeField] private GameObject Meter;
    [SerializeField] private GameObject MinimapUI;
    [SerializeField] private GameObject TuneUI;
    [SerializeField] private GameObject TunningFeature;
    Animator radioAnim;
    Animator meterAnim;
    int index = 0;
    int switchindex = 0;
    public bool usingDetect = false;
    public bool usingMap = true;
    void Start()
    {
        radioAnim = Radio.GetComponent<Animator>();
        meterAnim = Meter.GetComponent<Animator>();
        TunningFeature.SetActive(false);
    }

    void Update()
    {
        OnOffRadio();
        SwitchingFuntion();
    }
        void OnOffRadio(){
            if(Input.GetKeyDown(KeyCode.E)){
                if(index==0){
                    radioAnim.SetBool("OFF", false);
                    radioAnim.SetBool("ON", true);
                    index=1;
                }else if(index==1){
                    radioAnim.SetBool("OFF", true);
                    radioAnim.SetBool("ON", false);
                    Reset();
                    index=0;
                }
            }
        }
        void SwitchingFuntion(){
            if(index ==1 && Input.GetKeyDown(KeyCode.Q)){
                if(switchindex==0){ //switch to tuning
                    TunningFeature.SetActive(true);
                    MinimapUI.SetActive(false);
                    TuneUI.SetActive(true);
                    meterAnim.SetBool("viewmap", false);
                    meterAnim.SetBool("usedetect", true);
                    switchindex = 1;
                    usingDetect = true;
                    usingMap = false;
                }else if(switchindex==1){ //switch to map
                    TunningFeature.SetActive(false);
                    MinimapUI.SetActive(true);
                    TuneUI.SetActive(false);
                    meterAnim.SetBool("viewmap", true);
                    meterAnim.SetBool("usedetect", false);
                    switchindex = 0;
                    usingDetect = false;
                    usingMap = true;
                }
            }
        }

        void Reset(){
            usingDetect = false;
            usingMap = true;
            switchindex = 0;
        }
        void OpenMap(){
            //Minimap.SetActive(true);
        }

    
}
