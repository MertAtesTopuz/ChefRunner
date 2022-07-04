using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] Transform chefPos;
    Vector3 mesafe;

    void LateUpdate()
    {
        mesafe = new Vector3(chefPos.position.x, transform.position.y, chefPos.position.z - 4.1f);
        transform.position = Vector3.Lerp(transform.position, mesafe, Time.deltaTime);
    }
}
