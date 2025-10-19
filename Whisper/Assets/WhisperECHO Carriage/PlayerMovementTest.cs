using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetKeyDown(KeyCode.Space)){
        //     Debug.Log("yes");
        // }

        // // Get input from WASD/Arrow keys
        // float moveX = Input.GetAxis("Horizontal"); // A/D or Left/Right
        // float moveZ = Input.GetAxis("Vertical");   // W/S or Up/Down

        // // Create movement vector
        // Vector3 move = new Vector3(moveX, 0, moveZ);

        // // Move object
        // transform.Translate(move * moveSpeed * Time.deltaTime, Space.World);

        // // Optional: rotate the object to face the direction of movement
        // if (move != Vector3.zero)
        // {
        //     transform.forward = move;
        // }
    }
}
