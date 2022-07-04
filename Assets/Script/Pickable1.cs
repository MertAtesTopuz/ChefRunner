using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickable1 : MonoBehaviour
{

    [SerializeField] GameObject DoorsHF;
    [SerializeField] GameObject Cylinder;
    [SerializeField] GameObject CubeImage;
    [SerializeField] GameObject CylinderImage;
    [SerializeField] GameObject HamburgerTaban;
    [SerializeField] GameObject HamburgerTabanM;
    [SerializeField] GameObject CubeFalseMain;
    [SerializeField] GameObject MainDoor;
    [SerializeField] GameObject StarSFX;

    public GameObject MyPlateAnim;
    PlateAnim plateanim;

    private void Awake() 
    {
        plateanim = MyPlateAnim.GetComponent<PlateAnim>();    
    }
   
    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "Cube1")
        {
            if(StarSFX != null)
            {
                Instantiate(StarSFX,transform.position,Quaternion.identity);
            }
            DoorsHF.SetActive(true);
            CubeImage.SetActive(true);
            HamburgerTaban.SetActive(true);
            HamburgerTabanM.SetActive(true);
            plateanim.HPlane();
            CubeFalseMain.SetActive(false);
            MainDoor.SetActive(false);

        }

        else if (gameObject.tag == "Cylinder1")
        {
            Cylinder.SetActive(true);
            CylinderImage.SetActive(true);
        }


        gameObject.SetActive(false);

    }
}
