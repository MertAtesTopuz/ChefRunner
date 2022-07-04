using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Obsatcle : MonoBehaviour
{
    
    [SerializeField] GameObject GGPnl;

    private void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "Player")
        {
            Time.timeScale = 0.0f;
            GGPnl.SetActive(true);
        }
    }
}
