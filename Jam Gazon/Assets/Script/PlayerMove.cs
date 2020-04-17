using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    [Header("Health")]
    public float MaxHealth = 100;
    public static float health;
    public Image healthBar;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        
        health = MaxHealth;

    }

    void Update()
    {
        healthBar.fillAmount = health / MaxHealth;

        if (health <= 0)
        {

            Debug.Log("mort");
            //Die();
        }
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
