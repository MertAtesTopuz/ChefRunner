using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickable1 : MonoBehaviour
{

    [SerializeField] GameObject Cube;
    [SerializeField] GameObject Cylinder;
    [SerializeField] GameObject CubeImage;
    [SerializeField] GameObject CylinderImage;

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "Cube1")
        {
            Cube.SetActive(true);
            CubeImage.SetActive(true);
        }

        else if (gameObject.tag == "Cylinder1")
        {
            Cylinder.SetActive(true);
            CylinderImage.SetActive(true);
        }

        gameObject.SetActive(false);

    }
}
