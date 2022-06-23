using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    Rigidbody2D rb2d;
    [SerializeField] float torquePower = 1.0f;
    [SerializeField] float boostSpeed = 40.0f;
    [SerializeField] float normalSpeed = 25.0f;
    [SerializeField] float slowSpeed = 15.0f;

    SurfaceEffector2D surfaceEffector2D;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    void Update()
    {
        rotatePlayer();
        speedUp();
    }

    void speedUp() {

        if(Input.GetKey(KeyCode.UpArrow)) {
            surfaceEffector2D.speed = boostSpeed;
        } else if(Input.GetKey(KeyCode.DownArrow)) {
            surfaceEffector2D.speed = slowSpeed;
        } else {
            surfaceEffector2D.speed = normalSpeed;
        }
    }

    void rotatePlayer() {
        if(Input.GetKey(KeyCode.LeftArrow)) {
            rb2d.AddTorque(torquePower);
        }

        if(Input.GetKey(KeyCode.RightArrow)) {
            rb2d.AddTorque(-torquePower);
        }
    }
}
