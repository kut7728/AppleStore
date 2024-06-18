using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLockSwitch : MonoBehaviour
{
    bool switchState = true;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown("space")) {
            if (switchState) {
                Cursor.lockState = CursorLockMode.Locked;
                switchState = false;
            } else {
                Cursor.lockState = CursorLockMode.None;
                switchState = true;
            }
            
        }
    }
}
