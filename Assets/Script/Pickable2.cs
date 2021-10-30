using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable2 : MonoBehaviour
{
    [SerializeField] GameObject CubeK;
    [SerializeField] GameObject CubeM;
    [SerializeField] GameObject CubeKa;
    [SerializeField] GameObject CubeMo;
    [SerializeField] GameObject CubeS;
    [SerializeField] GameObject CubeP;
    [SerializeField] GameObject CubeG;
    [SerializeField] GameObject CubeT;
   // [SerializeField] GameObject CubeFalse1b2;
   // [SerializeField] GameObject CubeFalse1b3;
   // [SerializeField] GameObject CubeFalse1b4;
    [SerializeField] GameObject CubeFalse2;
   // [SerializeField] GameObject CubeFalse2b2;
   // [SerializeField] GameObject CubeFalse2b3;
    [SerializeField] GameObject CubeFalse3;
   // [SerializeField] GameObject CubeFalse3b2;
    [SerializeField] GameObject CubeFalse4;

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "CubeK")
        {
            CubeK.SetActive(true);
            CubeFalse2.SetActive(true);
        }

        if (gameObject.tag == "CubeMo1")
        {
            CubeMo.SetActive(true);
            CubeFalse2.SetActive(true);
        }

        if (gameObject.tag == "CubeM")
        {
            CubeM.SetActive(true);
            CubeFalse3.SetActive(true);
        }

        if (gameObject.tag == "CubeP1")
        {
            CubeP.SetActive(true);
            CubeFalse3.SetActive(true);
        }

        if (gameObject.tag == "CubeS")
        {
            CubeS.SetActive(true);
            CubeFalse4.SetActive(true);
        }

        if (gameObject.tag == "CubeKa1")
        {
            CubeKa.SetActive(true);
            CubeFalse4.SetActive(true);
        }

        if (gameObject.tag == "CubeT")
        {
            CubeT.SetActive(true);
        }

        if (gameObject.tag == "CubeG")
        {
            CubeG.SetActive(true);
        }

        gameObject.SetActive(false);
    }

}




/*   private void OnTriggerEnter(Collider other)
    {

        if (gameObject.tag == "CubeK")
        {
            CubeK.SetActive(true);
            CubeFalse2.SetActive(true);
        }
        else if (gameObject.tag == "CubeMo1")
        {
            CubeFalse1b2.SetActive(true);
        }
        else if (gameObject.tag == "CubeMo2")
        {
            CubeFalse1b3.SetActive(true);
        }
        else if (gameObject.tag == "CubeMo3")
        {
            CubeFalse1b4.SetActive(true);
        }


        else if (gameObject.tag == "CubeM")
        {
            CubeM.SetActive(true);
            CubeFalse3.SetActive(true);
        }
        else if (gameObject.tag == "CubeP1")
        {
            CubeFalse2b2.SetActive(true);
        }
        else if (gameObject.tag == "CubeP2")
        {
            CubeFalse2b3.SetActive(true);
        }

        else if (gameObject.tag == "CubeS")
        {
            CubeS.SetActive(true);
            CubeFalse4.SetActive(true);
        }
        else if (gameObject.tag == "CubeKa1")
        {
            CubeFalse3b2.SetActive(true);
        }

        else if (gameObject.tag == "CubeT")
        {
            CubeT.SetActive(true);
        }

        gameObject.SetActive(false);

    }*/