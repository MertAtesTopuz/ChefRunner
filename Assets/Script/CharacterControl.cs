using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField]
    float speed = 2.0f;

    public bool canRun = true;
    bool left;
    bool right;

    Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch finger = Input.GetTouch(0);

            if (finger.deltaPosition.x > 100.0)
            {
                left = false;
                right = true;
            }

            if (finger.deltaPosition.x < -100.0)
            {
                left = true;
                right = false;
            }
        }

        if (right == true)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(-1.7f, transform.position.y, transform.position.z), speed * Time.deltaTime);
        }

        if (left == true)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(1.7f, transform.position.y, transform.position.z), speed * Time.deltaTime);
        }

        if (canRun == true)
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }

        if (canRun == false)
        {
            animator.SetBool("Stop", true);
        }
    }
}
