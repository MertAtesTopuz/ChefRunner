using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable2 : MonoBehaviour
{
    [SerializeField] GameObject SaladT;
    [SerializeField] GameObject SaladM;
    [SerializeField] GameObject CucumberT;
    [SerializeField] GameObject CucumberM;
    [SerializeField] GameObject MeatT;
    [SerializeField] GameObject MeatM;
    [SerializeField] GameObject ChickenT;
    [SerializeField] GameObject ChickenM;
    [SerializeField] GameObject YCheeseT;
    [SerializeField] GameObject YCheeseM;
    [SerializeField] GameObject WCheeseT;
    [SerializeField] GameObject WCheeseM;
    [SerializeField] GameObject TomatoT;
    [SerializeField] GameObject TomatoM;
    [SerializeField] GameObject OnionT;
    [SerializeField] GameObject OnionM;
    [SerializeField] GameObject WBreadT;
    [SerializeField] GameObject WBreadM;
    [SerializeField] GameObject BBreadT;
    [SerializeField] GameObject BBreadM;

    public GameObject MyPlateAnim;
    [SerializeField] GameObject StarSFX;
    PlateAnim plateanim;

    [SerializeField] GameObject CubeFalse1;
    [SerializeField] GameObject CubeFalse2;
    [SerializeField] GameObject CubeFalse3;
    [SerializeField] GameObject CubeFalse4;
    [SerializeField] GameObject CubeFalse5;
    [SerializeField] GameObject CubeFalse1O;
    [SerializeField] GameObject CubeFalse2O;
    [SerializeField] GameObject CubeFalse3O;
    [SerializeField] GameObject CubeFalse4O;
    [SerializeField] GameObject CubeFalse5O;


    private void Awake() 
    {
        plateanim = MyPlateAnim.GetComponent<PlateAnim>();  
    }
    private void OnTriggerEnter(Collider other)
    {
        //kapı 1
        if (gameObject.tag == "Salad-d")
        {
            if(StarSFX != null)
            {
                Instantiate(StarSFX,transform.position,Quaternion.identity);
            }
            SaladT.SetActive(true);
            SaladM.SetActive(true);
            plateanim.HSalad();
            CubeFalse1.SetActive(false);
            CubeFalse1O.SetActive(false);
        }

        if (gameObject.tag == "Cucumber-d")
        {
            if(StarSFX != null)
            {
                Instantiate(StarSFX,transform.position,Quaternion.identity);
            }
            CucumberT.SetActive(true);
            CucumberM.SetActive(true);
            CubeFalse1.SetActive(false);
            CubeFalse1O.SetActive(false);
            
        }       

     /*   if(SaladT.activeSelf == true && CucumberT.activeSelf == true)
        {
            int random = Random.Range(1,2);

            if(random == 1)
            {
            SaladT.SetActive(true);
            SaladM.SetActive(true);
            }

            if(random == 2)
            {
            CucumberT.SetActive(true);
            CucumberM.SetActive(true);
            }

            // CubeFalse2.SetActive(true);
        } */

        //kapı 2
        if (gameObject.tag == "Meat-d")
        {
            if(StarSFX != null)
            {
                Instantiate(StarSFX,transform.position,Quaternion.identity);
            }
            MeatT.SetActive(true);
            MeatM.SetActive(true);
            plateanim.HMeat();
            CubeFalse2.SetActive(false);
            CubeFalse2O.SetActive(false);
        }

        if (gameObject.tag == "Chicken-d")
        {
            if(StarSFX != null)
            {
                Instantiate(StarSFX,transform.position,Quaternion.identity);
            }
            ChickenT.SetActive(true);
            ChickenM.SetActive(true);
            CubeFalse2.SetActive(false);
            CubeFalse2O.SetActive(false);
        }

        //kapı 3
        if (gameObject.tag == "YCheese-d")
        {  
            if(StarSFX != null)
            {
                Instantiate(StarSFX,transform.position,Quaternion.identity);
            }
            YCheeseT.SetActive(true);
            YCheeseM.SetActive(true);
            plateanim.HYCheese();
            CubeFalse3.SetActive(false);
            CubeFalse3O.SetActive(false);
        }

        if (gameObject.tag == "WCheese-d")
        {
            if(StarSFX != null)
            {
                Instantiate(StarSFX,transform.position,Quaternion.identity);
            }
            WCheeseT.SetActive(true);
            WCheeseM.SetActive(true);
            CubeFalse3.SetActive(false);
            CubeFalse3O.SetActive(false);
        }

        //kapı 4
        if (gameObject.tag == "Tomato-d")
        {
            if(StarSFX != null)
            {
                Instantiate(StarSFX,transform.position,Quaternion.identity);
            }
            TomatoT.SetActive(true);
            TomatoM.SetActive(true);
            plateanim.HTomato();
            CubeFalse4.SetActive(false);
            CubeFalse4O.SetActive(false);
        }

        if (gameObject.tag == "Onion-d")
        {
            if(StarSFX != null)
            {
                Instantiate(StarSFX,transform.position,Quaternion.identity);
            }
            OnionT.SetActive(true);
            OnionM.SetActive(true);
            CubeFalse4.SetActive(false);
            CubeFalse4O.SetActive(false);
        }

        //kapı 5
         if (gameObject.tag == "WBread-d")
        {
            if(StarSFX != null)
            {
                Instantiate(StarSFX,transform.position,Quaternion.identity);
            }
            WBreadT.SetActive(true);
            WBreadM.SetActive(true);
            plateanim.HWBread();
            CubeFalse5.SetActive(false);
            CubeFalse5O.SetActive(false);
        }

        if (gameObject.tag == "BBread-d")
        {
            if(StarSFX != null)
            {
                Instantiate(StarSFX,transform.position,Quaternion.identity);
            }
            BBreadT.SetActive(true);
            BBreadM.SetActive(true);
            CubeFalse5.SetActive(false);
            CubeFalse5O.SetActive(false);
        }

        gameObject.SetActive(false);
    }

}