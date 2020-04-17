using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D body;

    float horizontal;
    float vertical;
    public Vector2 Direction = Vector2.zero;

    [Header("Speed Player")]
    public float runSpeed = 20.0f;

    [Header("Tir Player")]
    public GameObject bullet;
    private float TimeShots;
    public float startTimeShots;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();


    }

    void Update()
    {



    }

    private void FixedUpdate()
    {
        body.velocity = Direction * runSpeed;
    }

    public void Shot()
    {

            Instantiate(bullet, transform.position, Quaternion.identity);
            TimeShots = startTimeShots;
   
    }

}
