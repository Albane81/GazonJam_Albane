using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D body;

    float horizontal;
    float vertical;

   
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
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        if (TimeShots <= 0)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            TimeShots = startTimeShots;
        }
        else
        {
            TimeShots -= Time.deltaTime;
        }

    }

    private void FixedUpdate()
    {
        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }

   
}
