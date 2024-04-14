using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InputsysScript : MonoBehaviour
{
    private void Update()
    {
        if (Input.anyKeyDown)
        {
            string keyPressed = Input.inputString;
            Debug.Log("pressed key" + keyPressed);
        }
    }
}
   
  
