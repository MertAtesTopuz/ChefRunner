using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final : MonoBehaviour
{
    CharacterControl Control;

    void Start()
    {
        Control = FindObjectOfType<CharacterControl>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Control.canRun = false;
        }
        
    }
}
