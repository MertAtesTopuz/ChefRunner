using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateAnim : MonoBehaviour
{
    Animator anim;
    private void Awake() 
    {
        anim = GetComponent<Animator>();
    }

    public void HPlane()
    {   
        anim.SetTrigger("PlaneFall");  
    }

    public void HSalad()
    {   
        anim.SetTrigger("SaladFall");  
    }

    public void HMeat()
    {   
        anim.SetTrigger("MeatFall");  
    }

    public void HYCheese()
    {   
        anim.SetTrigger("YCheeseFall");  
    }
    public void HTomato()
    {   
        anim.SetTrigger("TomatoFall");  
    }

    public void HWBread()
    {   
        anim.SetTrigger("WBreadFall");  
    }
}
