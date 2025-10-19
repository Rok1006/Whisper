using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private GameObject Radio;
    Animator radioAnim;
    int index = 0;
    void Start()
    {
        radioAnim = Radio.GetComponent<Animator>();
        //Radio.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)){
            if(index==0){
                //Radio.SetActive(true);
                radioAnim.SetBool("OFF", false);
                radioAnim.SetBool("ON", true);
                index=1;
            }else if(index==1){
                radioAnim.SetBool("OFF", true);
                radioAnim.SetBool("ON", false);
                //Radio.SetActive(false);
                index=0;
            }
        }
    }
}
