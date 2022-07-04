using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalNew : MonoBehaviour
{
    CharacterControl Control;
    [SerializeField] GameObject TablePlate;
    [SerializeField] GameObject ChefPlate;
    [SerializeField] GameObject Chef;
    [SerializeField] GameObject FinalPnl;
    void Start()
    {
        Control = FindObjectOfType<CharacterControl>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Chef.transform.Rotate(transform.rotation.x, 180.0f,transform.rotation.z);
            Chef.transform.position = new Vector3(0.02f, transform.position.y, transform.position.z);
            TablePlate.SetActive(true);
            ChefPlate.SetActive(false);
            Control.canRun = false;
            StartCoroutine(timer10());
        }
        
    }
    
    IEnumerator timer10()
    {
        yield return new WaitForSeconds(10);
        FinalPnl.SetActive(true);
    }
}
