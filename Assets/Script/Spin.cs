using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField] GameObject Saw;
    [SerializeField] int TurnX;
    [SerializeField] int TurnY;
    [SerializeField] int TurnZ;

    void Update()
    {
        Saw.transform.Rotate(TurnX,TurnY,TurnZ);
    }
}
